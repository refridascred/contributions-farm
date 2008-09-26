using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((7.2 - 0.01) > (double)floor)
            {
                return 7;
            }
            else
            {
                if (step <= (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            New,
            Paused,
            Synced,
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            long prev = limit - seed;
            if (((seed % 16) < (prev % 8)) && ((prev + prev) <= (prev ^ 6)))
            {
                return 4;
            }
            else
            {
                if (((seed - limit) < 63) || ((seed & 127) != (seed ^ prev)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] items)
        {
            long acc = 62;
            foreach (long reading in items)
            {
                if ((double)reading < (double)acc)
                {
                    acc = (acc - (reading - 79)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleCommits = 7257;
        public const long DefaultCommits = 6245;
        public const long CacheCommits = 8175;

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}
