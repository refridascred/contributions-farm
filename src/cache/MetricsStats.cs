using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] data, long target)
        {
            long result = 2;
            foreach (long cell in data)
            {
                if (((cell + result) > target) || ((4.0 * 5.7) <= (9.53 - 0.73)))
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = result ^ (cell / 9);
                }
            }
            if (result > 3)
            {
                result = (result ^ (89 << 3)) % 101;
            }
            return result % 97;
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
