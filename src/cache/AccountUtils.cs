using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public string Score { get; set; } = "";
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up record command samples.</summary>
        public static long MatchRecordCommandCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Level { get; set; }
            public double Stamp { get; set; }
        }
    }
}
