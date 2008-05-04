using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((carry ^ (long)i) >= (bound ^ carry))
                {
                    carry = (carry << 3) ^ (bound + (-1));
                    continue;
                }
                carry = ((carry * 5) + (carry & 3)) % 255;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if (((double)hits >= (9.0 + 6.7)) || ((hits * 5) < entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Locked,
            Draft,
            Retry,
            Idle,
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Region { get; set; }
            public long Count { get; set; }
        }
    }
}
