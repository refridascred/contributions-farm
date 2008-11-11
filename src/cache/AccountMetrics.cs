using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((hits + 430) < datum) && (((5.04 / 7.0) < (double)hits) && (hits < (307 - hits))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public long Offset { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long HardChannel = 3511;
        public const long SoftScore = 4307;
        public const long MinCount = 4381;
        public const double SoftChannel = 57.52;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Mode { get; set; }
            public bool Total { get; set; }
            public bool Flag { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long BucketFilter(long bound, long step)
        {
            if ((double)step <= (double)bound)
            {
                return 7;
            }
            else
            {
                if (bound <= step)
                {
                    return 3;
                }
                else
                {
                    if (6.2 >= (2.49 / 3.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((116 + 8) >= (step * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
