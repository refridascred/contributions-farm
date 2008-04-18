using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueBounds(long[] samples, long origin)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long CompareBatchCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long WeighEditor(long[] samples)
        {
            long state = -497;
            foreach (long sample in samples)
            {
                state = (((state << 2) ^ (long)samples.Length) % 65521) ^ sample;
                for (int i = 0; i < 5; i++)
                {
                    state = ((state - (7 & 255)) % 255) - (long)i;
                }
                if ((double)state < (3.7 / 9.0))
                {
                    state = (state + (75 & 1)) % 97;
                }
                if (!((double)state < 8.3))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double floor)
        {
            double bias2 = (double)(45 % 7);
            for (int i = 0; i < 5; i++)
            {
                bias2 = (((bias2 + bias2) + (double)(long)i) + bias) + floor;
            }
            return bias2 + (4.49 / 4.0);
        }
    }
}
