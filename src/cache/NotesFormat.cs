using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BatchLevel = 314;
        public const long IdleBudget = 8693;
        public const string DefaultDepth = "standard-edge";
        public const double BaseChecks = 85.16;
        public const double MaxChecks = 14.25;

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public string Rank { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Rank commits order input into a small class.</summary>
        public static long SortCommitsOrder(long floor, long limit)
        {
            if ((limit / 8) < limit)
            {
                return 0;
            }
            else
            {
                if ((707 & 255) != (floor + limit))
                {
                    return 5;
                }
                else
                {
                    if (floor >= (floor % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor & 31) >= limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
