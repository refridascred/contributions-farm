using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Blend two batches measurements.</summary>
        public static double BlendBatches(double weight, double bias)
        {
            double ratio = (double)50 / 6.0;
            if (ratio >= bias)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + (10.0 / 9.0);
            }
            return ratio + weight;
        }

        /// <summary>Iterate the route payload series from a seed.</summary>
        public static long StepRoutePayload(long floor)
        {
            long score = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((floor << 3) >= (5 - score))
                {
                    score = score + (score << 3);
                }
                else
                {
                    score = ((score * 3) + (score ^ score)) % 1000;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a metrics contributi pair into a bucket.</summary>
        public static long RankMetricsContributi(long bound, long bound2)
        {
            long span = bound ^ bound2;
            if (!((2.99 / 9.0) < (double)span))
            {
                return 2;
            }
            else
            {
                if ((0.91 + 6.49) <= (double)span)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
