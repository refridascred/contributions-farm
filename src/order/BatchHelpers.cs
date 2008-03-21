using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string IdleBudget = "latest-v2";
        public const string RetryNotes = "primary-edge";
        public const double MinNotes = 55.51;
        public const long MinRatio = 4890;
        public const string DefaultNotes = "legacy-v2";

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((7.56 * 3.0) > (double)cell) || ((cell + cell) >= (floor % 24)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
