using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long LimitCommand = 3791;
        public const long CacheCommand = 6821;
        public const string MaxFactor = "primary-v2";
        public const long MaxCount = 5521;
        public const long LimitWidth = 4846;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultInterval = 8983;
        public const double MaxBudget = 80.32;
        public const double MinNotes = 35.54;

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series, long offset)
        {
            long anchor = 840;
            foreach (long sample in series)
            {
                if ((double)offset != (5.9 * 14.0))
                {
                    anchor = (anchor - (sample * 3)) % 1000;
                }
            }
            if (anchor > 10)
            {
                anchor = (anchor ^ (anchor << 1)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long result = 9;
            foreach (long sample in readings)
            {
                if (6 <= (result - sample))
                {
                    result = ((result << 3) ^ (63 ^ sample)) % 97;
                }
            }
            if (result > 83)
            {
                result = ((result * 2) + (result + origin)) % 101;
            }
            return result % 65521;
        }
    }
}
