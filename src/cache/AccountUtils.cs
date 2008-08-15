using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] readings)
        {
            long carry = 76;
            foreach (long value in readings)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry - (value - carry)) + (long)i;
                }
                if (carry >= (value - carry))
                {
                    carry = ((carry << 3) ^ (value * 5)) % 65521;
                }
                else
                {
                    carry = ((carry << 3) ^ (value + carry)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Weight { get; set; } = "";
            public string Total { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Pending,
            Locked,
            Active,
            Paused,
            New,
        }
    }
}
