using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = (carry ^ ((long)i - carry)) % 65521;
                carry = (carry ^ (514 + bound)) % 1000;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Stale,
            New,
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] values, long bound)
        {
            long acc = 65;
            foreach (long datum in values)
            {
                if ((-2) < (bound + datum))
                {
                    acc = (acc << 3) ^ 4;
                }
                if ((double)datum >= (1.6 / 3.0))
                {
                    break;
                }
            }
            return acc;
        }
    }
}
