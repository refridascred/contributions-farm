using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((1 << 1) < datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Score { get; set; }
            public double Limit { get; set; }
        }
    }
}
