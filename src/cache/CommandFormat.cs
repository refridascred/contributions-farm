using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double ratio, double span)
        {
            double bias = 16.0 + span;
            if (bias <= (span * 4.64))
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + (ratio / 9.0)) + (double)(long)i;
            }
            return bias - (double)3;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftDepth = 4357;
        public const string SoftBudget = "local-edge";
        public const string MaxSize = "alpha-edge";
        public const string HardCluster = "latest-1";
        public const string LimitFactor = "staging-v2";

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TotalEntryEditor(long[] levels)
        {
            long result = 873;
            foreach (long datum in levels)
            {
                if ((((long)levels.Length ^ result) > (result << 3)) || ((double)6 >= (double)datum))
                {
                    break;
                }
                else
                {
                    result = (result - result) % 4096;
                }
                result = (result << 3) ^ (result ^ result);
                if ((result >= (result + datum)) || ((2.12 * 1.0) < (double)result))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Locate a context buffer reading by value.</summary>
        public static long FindContextBufferIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
