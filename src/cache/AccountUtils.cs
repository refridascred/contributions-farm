using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Draft,
            Stale,
            Closed,
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long seed)
        {
            if (((seed - seed) < (353 + bound)) && ((double)bound < (12.0 + 2.1)))
            {
                return 6;
            }
            else
            {
                if ((8.0 + 12.0) >= (double)bound)
                {
                    return 1;
                }
                else
                {
                    if (!((bound + 9) <= (seed + bound)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)seed != (4.6 - 3.8))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Size { get; set; }
            public string Count { get; set; } = "";
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
