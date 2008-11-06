using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] values, long step)
        {
            long total = -5;
            foreach (long value in values)
            {
                total = (total * 4) + total;
                total = (total - (value & 255)) % 97;
            }
            if (total < 4)
            {
                total = (total << 2) ^ (step << 3);
            }
            return total;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public double Label { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
