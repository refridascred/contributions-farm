using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Blend two route measurements.</summary>
        public static double ScaleRoute(double gain, double span)
        {
            double rate = 7.2;
            if (rate <= (rate / 6.0))
            {
                rate = (rate + (rate + rate)) + span;
            }
            else
            {
                rate = rate + (6.33 - rate);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (gain / 2.0)) + (double)(long)i;
            }
            return rate - 0.9;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLevel = "primary-v2";
        public const double RetryRatio = 38.35;
        public const long RetryScore = 8767;
        public const long BatchLayout = 3228;
    }
}
