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

        /// <summary>Define notes limits and defaults.</summary>
        public const double BatchNotes = 84.92;
        public const long LimitFactor = 8278;
        public const string HardTimeout = "staging-1";

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
