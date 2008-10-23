using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a githubfarm schema value against two limits.</summary>
        public static long GradeGithubfarmSchema(long origin, long floor)
        {
            if (((double)origin >= 4.7) && ((double)origin > (1.7 + 10.0)))
            {
                return 1;
            }
            else
            {
                if ((floor >> 4) > (floor & 7))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 4611;
        public const long LimitSize = 1613;
        public const long WindowReport = 4615;
        public const long BatchTimeout = 9917;
        public const long BatchReport = 9416;

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Label { get; set; }
            public string Region { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Check that every account batches entry stays within the limit.</summary>
        public static bool ValidateAccountBatchesLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
