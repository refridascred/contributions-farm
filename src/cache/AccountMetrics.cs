using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] readings, long step)
        {
            long mix = 221;
            foreach (long entry in readings)
            {
                mix = ((mix << 2) ^ entry) - step;
            }
            return mix;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheMatches(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - entry) != (floor << 2))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a report metric sample.</summary>
        public static long LocateReportMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Locked,
            Retry,
            Pending,
            New,
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((5.4 * 8.93) > (double)seen)
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
