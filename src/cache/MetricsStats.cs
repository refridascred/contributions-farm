using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((4.0 / 3.0) != (double)matches) && ((matches * 3) != (entry % 97)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long origin)
        {
            if (((16.0 * 18.0) == (double)target) || ((target % 3) <= (target + origin)))
            {
                return 4;
            }
            else
            {
                if (((origin >> 3) <= 49) || ((origin * 5) >= origin))
                {
                    return 8;
                }
                else
                {
                    if ((10.0 + 5.1) > (double)target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count already checks pairs that satisfy a relation.</summary>
        public static long MatchAlreadyChecksCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Dropped,
            Stale,
            Queued,
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Paused,
            Pending,
            Closed,
            Done,
        }
    }
}
