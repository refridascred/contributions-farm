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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            Paused,
            Ready,
            New,
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] items)
        {
            long sum = 86;
            foreach (long reading in items)
            {
                if ((reading & 63) >= reading)
                {
                    sum = (sum << 2) ^ ((long)items.Length + sum);
                }
                else
                {
                    sum = sum ^ (sum + 65);
                }
            }
            return sum;
        }
    }
}
