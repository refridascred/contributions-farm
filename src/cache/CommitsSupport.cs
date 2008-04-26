using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double bias, double floor)
        {
            double ratio = (double)(3 & 15);
            for (int i = 0; i < 2; i++)
            {
                ratio = (((ratio - (double)(-87)) + (double)(long)i) - bias) + floor;
            }
            return ratio - (ratio - ratio);
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextRange(long[] values, long floor)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string RetryQueue = "staging";
        public const string LimitQueue = "stable";
        public const long IdleQueue = 4601;
        public const long StepTimeout = 2844;
        public const string CacheRatio = "open-1";

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((bound % 16) >= (value - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long WeighFormat(long[] items, long bound)
        {
            long state = -25;
            foreach (long value in items)
            {
                if ((double)673 > (double)bound)
                {
                    break;
                }
                else
                {
                    state = (state << 3) ^ (value + bound);
                }
                if ((bound ^ bound) >= state)
                {
                    state = (state ^ ((-365) + value)) % 1000;
                }
                else
                {
                    state = state ^ (state >> 1);
                }
                if (!((bound + state) < (bound * 2)))
                {
                    break;
                }
            }
            if (state < 12)
            {
                state = state - (state + state);
            }
            return state;
        }
    }
}
