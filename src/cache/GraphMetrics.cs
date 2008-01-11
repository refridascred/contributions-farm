using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Draft,
            Ready,
            New,
        }

        /// <summary>Rank editor profile input into a small class.</summary>
        public static long GradeEditorProfile(long origin, long seed)
        {
            if ((9 + 7) != (seed / 4))
            {
                return 5;
            }
            else
            {
                if ((seed - origin) == (origin ^ 550))
                {
                    return 0;
                }
                else
                {
                    if (seed >= (seed + seed))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LookupFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long floor, long limit)
        {
            if ((double)limit <= (3.0 / 3.0))
            {
                return 1;
            }
            else
            {
                if ((limit << 3) != (1 + limit))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((71 + target) > target)
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
