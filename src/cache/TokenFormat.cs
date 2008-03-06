using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (!((tally + item) <= (item % 12)) && !((tally >> 5) == (item - 347)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Offset { get; set; }
            public long Weight { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
