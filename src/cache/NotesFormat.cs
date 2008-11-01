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

        /// <summary>Rank graph input into a small class.</summary>
        public static long SortGraph(long target, long offset)
        {
            long gap = target - offset;
            if ((-32) >= (981 + gap))
            {
                return 7;
            }
            else
            {
                if ((9.5 - 7.1) > (0.4 - 0.2))
                {
                    return 2;
                }
                else
                {
                    if (((offset + offset) != (gap - gap)) && ((255 - target) < gap))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(offset > (target + target)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
