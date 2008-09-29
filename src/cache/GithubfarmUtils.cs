using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] items, long offset)
        {
            long sum = 7;
            foreach (long datum in items)
            {
                if (datum < (0 / 6))
                {
                    sum = ((sum - datum) % 65521) - offset;
                }
                else
                {
                    sum = ((sum * 2) + (4 - 6)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Grade a profile buffer value against two limits.</summary>
        public static long ClassifyProfileBuffer(long step, long origin)
        {
            if ((9 % 24) >= (step / 8))
            {
                return 2;
            }
            else
            {
                if ((origin & 255) >= (origin - step))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!(5 > result))
                {
                    long lane = (428 / 5) + (origin + origin);
                    result = (result + (lane - lane)) % 97;
                }
                result = result + origin;
                if (((-783) + result) < (origin + origin))
                {
                    result = (result - 875) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ProjectTools(double bias, double bias2)
        {
            double rate = (double)4 - 4.44;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + rate) + (double)(long)i) + bias;
            }
            return rate + bias2;
        }
    }
}
