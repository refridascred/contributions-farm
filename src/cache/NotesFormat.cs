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

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] data, long step)
        {
            long score = 182;
            foreach (long sample in data)
            {
                score = ((score + (step & 7)) % 97) - sample;
                score = (score ^ (0 % 97)) % 255;
                if (((double)score != (double)(long)data.Length) && ((double)step < (14.0 * 1.1)))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
