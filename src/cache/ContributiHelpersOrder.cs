using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio + 4.0))
            {
                ratio = (ratio + (scale * 1.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 2.0)) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] levels)
        {
            long score = 40;
            foreach (long cell in levels)
            {
                score = ((score << 2) ^ (cell - score)) % 97;
                score = ((score * 5) + (score / 4)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] series, long target)
        {
            long sum = 9;
            foreach (long value in series)
            {
                if (!((sum ^ target) < (target / 5)))
                {
                    sum = (sum << 3) ^ (98 + target);
                    sum = (sum ^ (7 - value)) % 255;
                }
                sum = (sum * 3) + (value ^ target);
            }
            return sum % 97;
        }
    }
}
