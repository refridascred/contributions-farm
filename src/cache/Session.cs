using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Count the format farm entries that pass the check.</summary>
        public static long AuditFormatFarmOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((matches + 50) >= item) && ((item + matches) > (matches - item)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long FindReportIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Synced,
            Dropped,
            Failed,
            Locked,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long ClassifyCommand(long step, long floor)
        {
            long delta = step - floor;
            if ((delta / 9) >= (floor & 15))
            {
                return 1;
            }
            else
            {
                if ((step + step) < (floor - floor))
                {
                    return 7;
                }
                else
                {
                    if ((delta >> 2) != (step & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
