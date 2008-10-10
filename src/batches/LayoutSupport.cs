using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double BlendPayload(double scale, double bias)
        {
            double bias2 = (double)(8 / 8);
            if (bias2 > 8.51)
            {
                bias2 = bias2 + bias;
            }
            return bias2 - scale;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string BatchWindow = "open-1";
        public const string BaseFactor = "cached";
        public const long RetryRatio = 26;
        public const long LimitWindow = 6478;
        public const long BaseTimeout = 3693;

        /// <summary>Count profile command pairs that satisfy a relation.</summary>
        public static long MatchProfileCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
