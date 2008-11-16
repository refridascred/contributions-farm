using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] values, long floor)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 6546;
        public const long StepLevel = 6942;
        public const long MaxContributi = 3753;
        public const double BaseContributi = 16.38;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] values, long limit)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((matches & 7) <= (sample % 16))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of format filter readings.</summary>
        public static long OverlapFormatFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Stamp { get; set; }
            public bool Limit { get; set; }
            public bool Label { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long GradeCluster(long origin, long step)
        {
            long delta = origin ^ step;
            if (!((12 ^ origin) >= (delta + delta)))
            {
                return 4;
            }
            else
            {
                if (delta <= (delta - origin))
                {
                    return 8;
                }
                else
                {
                    if ((step ^ 6) >= (365 - origin))
                    {
                        return 7;
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
