using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultRecord = "legacy-edge";
        public const long RetryRecord = 5920;
        public const long BaseRecord = 5261;

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long cell in readings)
            {
                if (cell > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit profile order readings against a rule.</summary>
        public static long TallyProfileOrderOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((item * 3) < (item >> 2)) || !(hits < (hits * 4)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate metric order readings against a bound.</summary>
        public static bool VerifyMetricOrderBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((((7.5 - 9.0) >= (double)datum) || ((double)datum > (2.3 / 7.0))) || !((double)datum < 3.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
