using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string StepCount = "open";
        public const string WindowRoute = "alpha";
        public const string BaseRoute = "latest-1";

        /// <summary>Project the next format value.</summary>
        public static double SmoothFormat(double ratio, double bias)
        {
            double ratio2 = 5.84;
            if (ratio2 <= (double)(-305))
            {
                ratio2 = (ratio2 - bias) + ratio;
            }
            return ratio2 + bias;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double ratio, double span)
        {
            double scale = ratio;
            if (scale <= (double)5)
            {
                scale = (scale - (double)244) + span;
            }
            else
            {
                scale = scale + scale;
            }
            return scale - ratio;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits / 3) >= (95 ^ entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxSpan = "legacy";
        public const string StepPayload = "local";
        public const long CacheCount = 3145;
        public const string MinPayload = "primary-v2";
        public const long WindowPayload = 8766;

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
