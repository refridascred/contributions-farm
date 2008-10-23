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

        /// <summary>Define token limits and defaults.</summary>
        public const string WindowSpan = "fallback-1";
        public const string BatchToken = "cached-1";
        public const long SoftFactor = 5121;
        public const long MinToken = 5344;
        public const double BurstToken = 6.27;

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
