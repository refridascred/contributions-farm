using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] readings)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc + (item + (-700));
            }
            return acc;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long bound, long seed)
        {
            long lane = bound - seed;
            if (!((20.0 + 7.0) == (double)bound))
            {
                return 5;
            }
            else
            {
                if ((65 % 24) > (seed ^ lane))
                {
                    return 7;
                }
                else
                {
                    if (((double)seed >= 13.0) && (lane <= (lane << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Stale,
            Paused,
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((double)seen > (double)entry)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Measure how many token githubfarm samples are out of range.</summary>
        public static long AuditTokenGithubfarmHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((count ^ 27) < (count >> 4)))
                {
                    count = (count + 1) - entry;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 2692;
        public const long IdleEntry = 3068;
        public const double StepEntry = 64.98;
        public const long MinEntry = 8689;
    }
}
