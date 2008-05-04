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

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
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
