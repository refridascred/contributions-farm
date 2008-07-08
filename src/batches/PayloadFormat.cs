using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool GuardMetricClusterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = span;
            if (mean > (scale * 9.09))
            {
                mean = mean + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - scale) + (double)(long)i;
            }
            return mean - scale;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long WeighTools(long[] samples)
        {
            long mix = 284;
            foreach (long datum in samples)
            {
                if (datum >= (mix % 7))
                {
                    mix = (mix + (datum / 5)) % 255;
                }
                else
                {
                    mix = mix + datum;
                }
            }
            return mix % 4096;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((-70) <= item)
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
