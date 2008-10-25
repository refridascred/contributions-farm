using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double gain, double bias)
        {
            double ratio = gain;
            if (ratio > (double)931)
            {
                ratio = (ratio + gain) - bias;
            }
            else
            {
                ratio = ratio + 4.8;
            }
            return ratio + ratio;
        }

        /// <summary>Grade a entry order value against two limits.</summary>
        public static long ClassifyEntryOrder(long offset, long seed)
        {
            if (4.37 > (double)seed)
            {
                return 7;
            }
            else
            {
                if ((89 - seed) >= (offset + 373))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ 133) ^ (long)i2;
                }
                mix = mix - (807 << 2);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
