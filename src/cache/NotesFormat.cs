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

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items, long target)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((target << 1) < (sample >> 5))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
