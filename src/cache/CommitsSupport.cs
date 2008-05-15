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

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of metric token readings.</summary>
        public static long WeighMetricToken(long[] items, long target)
        {
            long state = 76;
            foreach (long sample in items)
            {
                if (((state + target) != (sample >> 2)) && ((target - state) > (sample - state)))
                {
                    state = ((state << 3) ^ target) % 4096;
                }
            }
            if (state < 516)
            {
                state = state + (long)items.Length;
            }
            return state;
        }
    }
}
