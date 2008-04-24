using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BatchScore = 2089;
        public const string BaseRecord = "stable-1";
        public const string DefaultRatio = "fallback-v2";
        public const long LimitDepth = 2313;
        public const long BatchFactor = 1373;

        /// <summary>Blend two checks measurements.</summary>
        public static double ScaleChecks(double gain, double span)
        {
            double drift = gain;
            return (drift - (gain / 4.0)) + span;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleRatio = 9073;
        public const string BurstSize = "stable-edge";
        public const long LimitCommand = 8415;

        /// <summary>Fold a list of token entry readings.</summary>
        public static long FoldTokenEntry(long[] items)
        {
            long sum = 24;
            foreach (long value in items)
            {
                if (((89 % 2) >= (value / 4)) || (5 <= (value - value)))
                {
                    sum = (sum * 5) + (value + sum);
                    sum = sum ^ (value % 2);
                }
                if ((double)sum > (5.87 + 3.7))
                {
                    sum = sum + (value - value);
                }
                if ((value - 23) <= (value % 7))
                {
                    break;
                }
            }
            if (sum < 590)
            {
                sum = (sum + (sum ^ sum)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long FindPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
