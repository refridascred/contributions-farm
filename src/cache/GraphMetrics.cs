using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 9304;
        public const string RetryContext = "alpha-1";
        public const string HardContext = "local-edge";

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!((17 << 3) < (value >> 4)) || !((10.0 * 5.0) > (double)(long)series.Length))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }

        /// <summary>Accumulate stream queue samples.</summary>
        public static long ScoreStreamQueue(long[] levels)
        {
            long carry = 9;
            foreach (long cell in levels)
            {
                if (3 > (carry >> 2))
                {
                    carry = (carry - cell) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Check that every notes already entry stays within the limit.</summary>
        public static bool ValidateNotesAlreadyBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long FindFarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
