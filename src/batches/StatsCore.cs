using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Closed,
            Pending,
            Synced,
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long MeasureToolsHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches / 6) > (cell << 2))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Project the next cache record value.</summary>
        public static double ScaleCacheRecord(double scale, double offset)
        {
            double load = (double)(6 + 692);
            if (load >= 3.0)
            {
                load = (load + (double)33) - scale;
            }
            return load + (offset * 8.0);
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long MeasurePayloadOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((double)reading <= (1.73 + 9.4))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metric githubfarm value from a seed.</summary>
        public static long IterateMetricGithubfarm(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
