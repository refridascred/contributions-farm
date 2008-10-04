using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxWidth = 6246;
        public const long MinEntry = 8350;
        public const double WindowEntry = 58.62;
        public const string StepTimeout = "staging-edge";

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!((7.17 / 6.0) >= (double)count) && ((9.7 / 8.0) >= (double)count))
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string SoftInterval = "legacy-edge";
        public const double SoftWidth = 39.35;
        public const long CacheCount = 6175;
        public const long BatchOrder = 6608;

        /// <summary>Scale a schema queue figure with a bias.</summary>
        public static double SmoothSchemaQueue(double scale, double offset)
        {
            double load = 14.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (offset * 5.0);
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
