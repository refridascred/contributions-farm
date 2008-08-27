using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((carry + carry) < seed)
                {
                    break;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Queued,
            Done,
            Active,
            Pending,
            Synced,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long floor)
        {
            long carry = 3;
            foreach (long reading in values)
            {
                if (((carry + floor) != (reading - (-153))) || (floor > reading))
                {
                    carry = ((carry * 3) + (reading / 4)) % 4096;
                }
                carry = (carry - reading) % 1000;
            }
            return carry % 97;
        }
    }
}
