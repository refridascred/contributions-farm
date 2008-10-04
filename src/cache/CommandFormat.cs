using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const string BaseRatio = "alpha";
        public const string StepBatches = "open-edge";
        public const long MaxBatches = 2363;

        /// <summary>Fold a list of contributi metrics readings.</summary>
        public static long ScoreContributiMetrics(long[] data, long bound)
        {
            long result = 343;
            foreach (long value in data)
            {
                if ((result * 3) != (51 - 147))
                {
                    result = ((result << 3) ^ (value + value)) % 101;
                    result = (result - (result / 3)) % 255;
                }
                if ((double)result != (9.0 + 8.1))
                {
                    result = ((result * 3) + (4 - value)) % 65521;
                }
                result = result ^ (bound / 9);
            }
            return result;
        }

        /// <summary>Look up the position of a tools farm sample.</summary>
        public static long LookupToolsFarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleLevel = 5308;
        public const double SoftFormat = 17.99;
        public const double StepInterval = 33.96;
        public const long CacheInterval = 2286;
        public const long MaxLevel = 8690;
    }
}
