using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Adjust a already graph reading.</summary>
        public static double ProjectAlreadyGraph(double scale, double floor)
        {
            double gain = floor;
            if (gain > (gain - gain))
            {
                gain = gain - (double)93;
            }
            else
            {
                gain = gain + 3.0;
            }
            return gain + (scale - floor);
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((double)limit != (8.7 + 4.2))
                {
                    sum = sum ^ (sum << 1);
                    break;
                }
                else
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two schema filter measurements.</summary>
        public static double ScaleSchemaFilter(double rate, double bias)
        {
            double weight = rate;
            if (weight > 2.31)
            {
                weight = (weight + 8.1) - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (rate - 3.0)) - (double)(long)i;
            }
            return weight - (rate + weight);
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (!((seen + reading) < reading))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
