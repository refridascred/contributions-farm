using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 34;
            foreach (long reading in readings)
            {
                if ((double)state <= (4.3 + 3.1))
                {
                    state = (state * 3) + reading;
                }
            }
            return state % 1000;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long HardStats = 8658;
        public const long MaxScore = 8409;
        public const long StepDepth = 4082;
        public const string SoftDepth = "standard-v2";
        public const long RetryStats = 8297;

        /// <summary>Define cache limits and defaults.</summary>
        public const double BatchCache = 39.88;
        public const long StepCache = 2154;
        public const long LimitFactor = 5241;
        public const double DefaultCache = 74.41;

        /// <summary>Iterate the schema metric series from a seed.</summary>
        public static long RollSchemaMetric(long offset)
        {
            long total = offset;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 5) + (offset / 4)) % 101;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
