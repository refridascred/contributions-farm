using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Closed,
            Failed,
            Ready,
            Stale,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long target2)
        {
            if ((double)target >= (4.1 + 20.0))
            {
                return 6;
            }
            else
            {
                if (1 < (target % 8))
                {
                    return 4;
                }
                else
                {
                    if ((660 >> 3) > (target2 + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target2 > (target2 + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 5633;
        public const string BatchNotes = "local-v2";
        public const double WindowSize = 84.45;
    }
}
