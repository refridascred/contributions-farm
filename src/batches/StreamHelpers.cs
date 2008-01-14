using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Synced,
            Closed,
            New,
            Locked,
        }

        /// <summary>Scale a account graph figure with a bias.</summary>
        public static double ProjectAccountGraph(double bias, double span)
        {
            double mean = (double)(-35) * 9.0;
            for (int i = 0; i < 4; i++)
            {
                mean = (((mean + (mean / 6.0)) - (double)(long)i) - bias) + span;
            }
            return mean + (double)749;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double BaseWidth = 30.27;
        public const string StepRoute = "fallback-edge";
        public const long BurstRoute = 3051;
        public const string DefaultRoute = "alpha-1";

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 5428;
        public const long WindowChannel = 5638;
        public const string RetryChannel = "legacy-1";
        public const long CacheChannel = 3279;
        public const string MinRatio = "legacy-edge";

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((((-346) ^ count) > (target + count)) && ((cell + count) < cell)) || (count > (cell * 5)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
