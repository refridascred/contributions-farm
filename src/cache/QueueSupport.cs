using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long bound, long limit)
        {
            long lane = bound + limit;
            if ((bound * 2) <= 79)
            {
                return 2;
            }
            else
            {
                if ((4 - limit) < (limit % 16))
                {
                    return 8;
                }
                else
                {
                    if ((3.2 + 8.0) != (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane >> 4) < 734)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Synced,
            Retry,
            Closed,
        }
    }
}
