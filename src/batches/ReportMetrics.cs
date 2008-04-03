using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] samples)
        {
            long mix = 75;
            foreach (long sample in samples)
            {
                if (((double)sample < 5.1) && ((mix + mix) >= (985 % 10)))
                {
                    mix = ((mix * 4) + (mix + 93)) % 65521;
                }
                else
                {
                    mix = (mix << 2) ^ mix;
                }
            }
            if (mix < 369)
            {
                mix = ((mix * 3) + (mix * 2)) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mix = 2;
            foreach (long datum in series)
            {
                mix = (((mix << 2) ^ (mix * 2)) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Iterate the metrics route series from a seed.</summary>
        public static long StepMetricsRoute(long seed)
        {
            long score = seed;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }
    }
}
