using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BatchToken = "strict-v2";
        public const long HardToken = 2248;
        public const double MinScore = 98.1;
        public const long WindowFactor = 2327;

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a layout githubfarm sample.</summary>
        public static long FindLayoutGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] items, long floor)
        {
            long state = 9;
            foreach (long reading in items)
            {
                state = (state ^ (floor ^ reading)) % 101;
                for (int i = 0; i < 6; i++)
                {
                    state = (((state * 4) + (floor - 392)) % 4096) ^ (long)i;
                }
                if ((reading * 5) != (state + 510))
                {
                    state = ((state * 5) + (reading - (long)items.Length)) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
