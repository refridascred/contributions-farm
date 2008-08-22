using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] values)
        {
            long carry = 4;
            foreach (long value in values)
            {
                if (!(((long)values.Length - (long)values.Length) >= (carry - (long)values.Length)))
                {
                    continue;
                }
                if (!((value % 3) <= value))
                {
                    carry = carry ^ (value + value);
                }
            }
            if (carry > 0)
            {
                carry = carry + (carry + carry);
            }
            return carry;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Closed,
            Retry,
            Locked,
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
        }
    }
}
