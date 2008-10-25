using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LookupSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (767 < (sample + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a payload support pair into a bucket.</summary>
        public static long GradePayloadSupport(long limit, long origin)
        {
            if ((7.91 + 4.7) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((limit ^ origin) >= (origin ^ limit))
                {
                    return 3;
                }
                else
                {
                    if (limit <= (origin & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((entry + entry) < (entry >> 1))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Done,
            Retry,
            Dropped,
        }
    }
}
