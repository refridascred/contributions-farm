using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every githubfarm stats entry stays within the limit.</summary>
        public static bool ValidateGithubfarmStatsBounds(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(((long)readings.Length % 7) != (9 - hits)) && ((hits % 7) != ((-31) / 8)))
                {
                    hits = ((hits + 2) ^ sample) + seed;
                }
            }
            return hits;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmGaps(long[] values, long floor)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if (((double)seen != (double)floor) && (seen > (floor + 380)))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Locked,
            Failed,
            Done,
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool ValidateChecksRange(long[] levels, long limit)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next record value.</summary>
        public static double AdjustRecord(double bias, double span)
        {
            double scale = span;
            if (scale <= (scale + span))
            {
                scale = scale + bias;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (span + bias);
        }
    }
}
