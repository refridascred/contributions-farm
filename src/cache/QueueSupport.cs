using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Closed,
            Synced,
        }

        /// <summary>Measure how many checks window samples are out of range.</summary>
        public static long AuditChecksWindowGaps(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (!((tally << 3) < 0))
                {
                    tally = (tally + 3) + cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (carry + carry)) % 255;
                if ((4.5 * 7.7) >= (double)(long)i)
                {
                    carry = carry + (94 ^ step);
                    carry = carry ^ (step + carry);
                }
                if (((long)i * 3) > carry)
                {
                    continue;
                }
                else
                {
                    carry = ((carry << 3) ^ (step - step)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
