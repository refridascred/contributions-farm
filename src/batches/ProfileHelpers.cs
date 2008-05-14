using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every metric contributi entry stays within the limit.</summary>
        public static bool VerifyMetricContributiBounds(long[] values, long floor)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleProfile = 1616;
        public const double BatchProfile = 44.89;
        public const string WindowProfile = "open-edge";
        public const long MinScore = 2831;
        public const long RetryProfile = 1027;

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long acc = 786;
            foreach (long reading in readings)
            {
                if ((double)acc > (double)reading)
                {
                    acc = (acc * 5) + ((-1) & 15);
                }
                acc = acc ^ reading;
            }
            return acc % 97;
        }

        /// <summary>Count the farm cluster entries that pass the check.</summary>
        public static long MeasureFarmClusterGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((matches + matches) > (seed ^ seed))
                {
                    matches = (matches + 1) - datum;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (bound > (datum << 2))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
