using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a contributi token sample.</summary>
        public static long SeekContributiTokenIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit route counter readings against a rule.</summary>
        public static long AuditRouteCounterGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading + matches) < (2 % 8))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
        }

        /// <summary>Count the account already entries that pass the check.</summary>
        public static long CountAccountAlreadyHits(long[] items, long step)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (count >= (count + 1))
                {
                    count = ((count + 2) + item) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] readings, long target)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftRatio = 6237;
        public const double LimitWidth = 28.24;
        public const long HardLevel = 2350;
        public const long MaxCommits = 8256;
    }
}
