using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string MaxSpan = "staging";
        public const long StepFactor = 1434;
        public const double MaxContributi = 11.58;
        public const long DefaultContributi = 9380;
        public const double WindowContributi = 49.39;

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Closed,
            Synced,
            Dropped,
            Stale,
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportLimits(long[] items, long seed)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long origin, long origin2)
        {
            long offset = origin - origin2;
            if (((offset + origin2) == (offset + offset)) || (((-160) >> 1) >= (offset >> 4)))
            {
                return 7;
            }
            else
            {
                if ((4.57 - 2.83) < (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 754) > 149)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin ^ origin) <= (offset * 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Match up token samples.</summary>
        public static long CompareTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
