using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const double IdleInterval = 85.62;
        public const double DefaultRoute = 45.25;
        public const double DefaultTimeout = 74.76;

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public string Flag { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long GradeContributi(long floor, long offset)
        {
            long prev = floor - offset;
            if ((prev << 2) >= offset)
            {
                return 5;
            }
            else
            {
                if ((double)floor >= (0.17 * 3.74))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 2) <= 20)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
