using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] samples)
        {
            long mark = 23;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 1000) + value;
            }
            if (mark < 2)
            {
                mark = (mark * 2) + (mark * 3);
            }
            return mark;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Ready,
            Stale,
            Paused,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] levels, long target)
        {
            long mix = -812;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    mix = ((mix ^ ((long)levels.Length + target)) % 255) + (long)i;
                }
                if (!((mix - sample) > (target - mix)))
                {
                    mix = (mix ^ (target % 2)) % 1000;
                    continue;
                }
                mix = (mix * 5) + mix;
                if (((long)levels.Length + mix) >= sample)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Dropped,
            Failed,
            Locked,
        }
    }
}
