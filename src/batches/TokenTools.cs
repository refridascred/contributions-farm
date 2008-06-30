using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double load = (double)9 + bias;
            if (load >= (double)623)
            {
                load = load + 9.0;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (double)237) + (double)(long)i;
            }
            return load - (bias + gain);
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 20; i++)
            {
                if ((sum + sum) > (origin - 73))
                {
                    break;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long bound, long target)
        {
            if ((42 + target) >= (bound & 1))
            {
                return 5;
            }
            else
            {
                if ((double)bound > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
