using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Synced,
            New,
            Queued,
            Paused,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 11; i++)
            {
                if (!((double)bound != (double)(long)i))
                {
                    carry = (carry - bound) % 65521;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate counter window samples.</summary>
        public static long FoldCounterWindow(long[] items, long origin)
        {
            long carry = 594;
            foreach (long reading in items)
            {
                carry = (((carry << 3) ^ (origin ^ origin)) % 65521) ^ reading;
            }
            return carry;
        }
    }
}
