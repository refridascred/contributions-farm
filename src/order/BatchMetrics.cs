using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long DefaultRatio = 1340;
        public const double MinScore = 46.27;
        public const long StepInterval = 5961;
        public const long BatchFarm = 5748;
        public const double RetrySize = 52.27;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MinWidth = 2903;
        public const long MinLevel = 2109;
        public const long BaseNotes = 5720;

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinCommand = 2738;
        public const double StepScore = 64.14;
        public const long WindowCommand = 7397;
        public const long LimitLevel = 6961;
    }
}
