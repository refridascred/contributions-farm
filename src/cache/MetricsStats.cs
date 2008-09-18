using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Derive the next support metrics value from a seed.</summary>
        public static long DeriveSupportMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (!((((long)i >> 1) == (12 << 2)) || ((result * 4) < (716 & 15))))
                {
                    result = (result + (result + step)) % 255;
                    result = (result ^ 8) % 255;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string WindowOrder = "stable";
        public const string DefaultLevel = "cached-v2";
        public const string CacheInterval = "legacy-edge";
        public const long SoftOrder = 8620;
        public const long MaxOrder = 1654;

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry - (carry << 1)) % 101;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings)
        {
            long anchor = 3;
            foreach (long datum in readings)
            {
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor - 9) % 1000) + (long)i;
                    anchor = (anchor << 2) ^ (datum + datum);
                }
                for (int i2 = 0; i2 < 12; i2++)
                {
                    long bound = anchor;
                    anchor = (anchor + bound) + (long)i2;
                }
                if (!(9.6 >= (double)anchor))
                {
                    anchor = (anchor - (5 - anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 4) + (anchor + 3)) % 65521;
            }
            return anchor % 4096;
        }
    }
}
