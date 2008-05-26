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

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Queued,
            Failed,
            Ready,
            Active,
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
