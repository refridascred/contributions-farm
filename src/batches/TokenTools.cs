using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((double)seen == (8.0 / 3.0))
                {
                    seen = (seen + 2) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long SeriesAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total + ((long)i >> 1)) ^ (long)i2;
                }
                total = ((total << 2) ^ 53) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double span)
        {
            double weight = (double)(75 - 2);
            if (weight > weight)
            {
                weight = weight + span;
            }
            else
            {
                weight = weight + (span + weight);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (weight * 15.0)) + (double)(long)i;
            }
            return weight - bias;
        }
    }
}
