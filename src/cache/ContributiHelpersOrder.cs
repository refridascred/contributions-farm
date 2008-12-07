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

        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] levels)
        {
            long state = -69;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 8; i++)
                {
                    state = (((state * 2) + ((long)i - state)) % 1000) + entry;
                }
                if ((414 % 24) >= ((long)levels.Length << 3))
                {
                    state = (state + (state - state)) % 1000;
                }
                else
                {
                    state = ((state * 5) + 8) % 1000;
                }
            }
            if (state < 81)
            {
                state = (state * 2) + (state % 8);
            }
            return state % 4096;
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
