using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool CheckStatsLimits(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of order readings.</summary>
        public static long MatchOrderCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((matches & 1) < (reading ^ matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Find the first metrics metric entry that matches the target.</summary>
        public static long LocateMetricsMetricIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((6 % 100) != (reading + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Failed,
            Closed,
            Locked,
        }
    }
}
