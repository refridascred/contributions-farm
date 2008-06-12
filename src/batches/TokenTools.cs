using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public long Mode { get; set; }
            public string Size { get; set; } = "";
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Score { get; set; }
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowBounds(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
