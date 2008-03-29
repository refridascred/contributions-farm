using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long TallyRouteHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count / 5) > sample)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long anchor = 6;
            foreach (long reading in samples)
            {
                anchor = anchor ^ (anchor % 10);
                if (((anchor ^ reading) != (reading % 16)) && (reading > (anchor & 15)))
                {
                    break;
                }
            }
            if (anchor < 142)
            {
                anchor = ((anchor * 3) + anchor) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!(((double)datum <= (3.85 - 9.53)) || (datum <= (datum / 7))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
