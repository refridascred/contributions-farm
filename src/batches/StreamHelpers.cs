using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Active,
            New,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double SmoothOrder(double scale, double bias)
        {
            double rate = scale / 7.0;
            if (rate <= 9.95)
            {
                rate = rate - (double)(-88);
            }
            else
            {
                rate = rate + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - (rate - scale);
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long seed, long origin)
        {
            if ((seed / 6) >= (origin + origin))
            {
                return 2;
            }
            else
            {
                if ((origin < seed) || ((origin << 3) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((seed + seed) != (origin + origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Label { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
