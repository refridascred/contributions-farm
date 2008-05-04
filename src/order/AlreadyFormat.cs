using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Count the profile stream entries that pass the check.</summary>
        public static long AuditProfileStreamOutliers(long[] values, long step)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell << 1) != (519 - cell))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] items, long bound)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every editor filter entry stays within the limit.</summary>
        public static bool GuardEditorFilterRange(long[] readings, long floor)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a githubfarm support counter forward.</summary>
        public static long RollGithubfarmSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!((floor * 3) < acc))
                {
                    acc = (acc - (floor >> 4)) % 101;
                }
                acc = ((acc << 3) ^ acc) % 4096;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Grade a report record value against two limits.</summary>
        public static long RankReportRecord(long floor, long floor2)
        {
            long step = floor + floor2;
            if ((floor ^ floor) <= step)
            {
                return 2;
            }
            else
            {
                if ((step % 100) >= (floor2 << 1))
                {
                    return 6;
                }
                else
                {
                    if ((floor * 4) > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
