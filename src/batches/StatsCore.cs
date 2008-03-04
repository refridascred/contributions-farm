using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank account format input into a small class.</summary>
        public static long GradeAccountFormat(long bound, long bound2)
        {
            long bound3 = bound - bound2;
            if ((double)bound < (double)bound2)
            {
                return 3;
            }
            else
            {
                if (!((bound3 << 1) < (bound3 - (-3))))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 1025;
        public const long BaseMetric = 7897;
        public const long MinMetric = 8908;
        public const double HardScore = 88.08;

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public string Level { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
