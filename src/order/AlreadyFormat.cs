using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (datum <= (datum * 2))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Ready,
            Active,
            Locked,
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
