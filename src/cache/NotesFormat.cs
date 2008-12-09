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

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double AdjustGithubfarm(double gain, double offset)
        {
            double load = (double)11 - 11.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + gain) + (double)(long)i;
            }
            return load + (offset / 4.0);
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
