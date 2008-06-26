using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine session cache values into a single score.</summary>
        public static long FoldSessionCache(long[] series)
        {
            long anchor = 40;
            foreach (long reading in series)
            {
                if (!((anchor >> 5) <= reading))
                {
                    anchor = ((anchor * 4) + (779 ^ reading)) % 101;
                }
                if (!((anchor % 60) == (928 ^ anchor)))
                {
                    break;
                }
            }
            if (anchor > (-59))
            {
                anchor = ((anchor * 5) + anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (1.7 - 3.7))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string BasePayload = "cached-1";
        public const double StepPayload = 78.58;
        public const long SoftTimeout = 7345;

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double offset)
        {
            double ratio2 = (double)(937 + (-613));
            if (ratio2 > (double)5)
            {
                ratio2 = ratio2 - 2.0;
            }
            else
            {
                ratio2 = ratio2 - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - offset;
        }
    }
}
