using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] samples, long step)
        {
            long mark = 3;
            foreach (long entry in samples)
            {
                if (step > (mark & 7))
                {
                    mark = ((mark + (step << 2)) % 97) ^ entry;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Stale,
            Done,
            Idle,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((seed << 1) >= (hits + 7))
                {
                    hits = (hits + 3) + cell;
                }
            }
            return hits;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (62 > item)
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }
    }
}
