using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinLevel = 3377;
        public const string RetryTimeout = "alpha-v2";
        public const long StepCluster = 1368;
        public const double SoftCluster = 18.15;

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Rank metrics githubfarm input into a small class.</summary>
        public static long GradeMetricsGithubfarm(long bound, long target)
        {
            if ((target % 12) > (target - bound))
            {
                return 0;
            }
            else
            {
                if (((bound & 127) == (bound & 31)) && (target < (bound % 3)))
                {
                    return 7;
                }
                else
                {
                    if (!((bound / 8) == (bound / 9)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target > (206 ^ bound)) || ((double)target >= (9.2 / 4.0)))
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

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= floor) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
        }
    }
}
