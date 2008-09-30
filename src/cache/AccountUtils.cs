using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
