using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of stats batches entries.</summary>
        public static long TallyStatsBatches(long[] series)
        {
            long mix = 434;
            foreach (long item in series)
            {
                if (!((8.48 + 4.13) < (double)mix))
                {
                    mix = (mix - (item + item)) % 97;
                }
                else
                {
                    mix = (mix * 2) + (mix + item);
                }
            }
            return mix;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples, long target)
        {
            long anchor = 948;
            foreach (long value in samples)
            {
                anchor = (anchor + ((long)samples.Length + target)) % 1000;
                if ((24 << 3) > (anchor & 63))
                {
                    anchor = anchor + (target - value);
                }
            }
            return anchor;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Ready,
            Done,
            Stale,
            Locked,
            Paused,
        }

        /// <summary>Audit format commits readings against a rule.</summary>
        public static long AuditFormatCommitsHits(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((long)levels.Length >= seen)
                {
                    seen = ((seen + 1) - value) - step;
                }
            }
            return seen;
        }
    }
}
