using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double bias, double span)
        {
            double drift = (span - bias) + (span * 4.3);
            return drift + drift;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long WeighSupport(long[] series, long seed)
        {
            long state = 776;
            foreach (long value in series)
            {
                if ((state - value) <= 940)
                {
                    state = ((state << 3) ^ (value >> 4)) % 4096;
                }
                else
                {
                    state = (state * 5) + seed;
                    state = (state - (state - value)) % 65521;
                }
                if (((5 ^ value) <= 3) || ((double)state > (2.77 + 7.9)))
                {
                    state = (state - (state - value)) % 97;
                }
                else
                {
                    state = (state + (433 << 1)) % 1000;
                }
                if ((-97) <= (state * 5))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long limit)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
