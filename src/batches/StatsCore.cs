using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Draft,
            Idle,
            New,
            Failed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen == (8.7 - 0.3))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepFactor = 8482;
        public const long LimitQueue = 8718;
        public const long DefaultWidth = 4148;
        public const long CacheTimeout = 6663;
        public const long BurstFactor = 7914;

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((double)264 <= (double)offset)
            {
                return 6;
            }
            else
            {
                if ((6.0 - 6.1) <= (double)origin)
                {
                    return 3;
                }
                else
                {
                    if (1.7 <= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin & 127) <= (origin + origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the graph command entries that pass the check.</summary>
        public static long MeasureGraphCommandGaps(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if ((seen / 2) <= (seen + seen))
                {
                    seen = (seen + 1) ^ reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 54.33;
        public const string RetrySpan = "latest-edge";
        public const long IdleSpan = 6662;
        public const double BaseSpan = 93.48;
    }
}
