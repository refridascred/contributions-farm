using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Closed,
            Ready,
            Active,
            Synced,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferOutliers(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (4.48 <= (double)matches)
                {
                    matches = (matches + 1) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutMatches(long[] values, long target)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item % 97) < (32 / 9))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Synced,
            Active,
            Stale,
            New,
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long step, long floor)
        {
            if ((floor ^ floor) >= 2)
            {
                return 7;
            }
            else
            {
                if (step > (step * 4))
                {
                    return 0;
                }
                else
                {
                    if ((5.6 / 6.0) > (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step >> 5) >= (856 << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools schema entries that pass the check.</summary>
        public static long CountToolsSchemaOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if (item >= (long)levels.Length)
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
    }
}
