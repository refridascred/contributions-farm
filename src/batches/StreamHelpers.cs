using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] data)
        {
            long mark = 647;
            foreach (long datum in data)
            {
                if (((double)datum < (13.0 * 6.6)) && (4.64 < (double)mark))
                {
                    mark = (mark + (datum + mark)) % 4096;
                }
                if ((datum << 2) < (datum % 10))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Locked,
            Pending,
            Dropped,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long SeriesStats(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double AdjustContributi(double weight, double floor)
        {
            double drift = weight;
            if (drift >= weight)
            {
                drift = (drift + weight) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (11.0 * 3.8)) + (double)(long)i;
            }
            return drift + (drift + drift);
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long ScorePayload(long[] samples, long target)
        {
            long state = 1;
            foreach (long cell in samples)
            {
                if (4 >= (target / 6))
                {
                    state = ((state ^ (78 << 2)) % 65521) - cell;
                }
            }
            if (state < 4)
            {
                state = (state * 4) + (target - target);
            }
            return state;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinDepth = 424;
        public const long BaseRoute = 8641;
        public const long HardBudget = 2464;
        public const string SoftRoute = "cached-edge";
        public const string IdleWidth = "primary-1";
    }
}
