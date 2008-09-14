using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a metric layout counter forward.</summary>
        public static long IterateMetricLayout(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long DigestEditor(long[] data)
        {
            long carry = -2;
            foreach (long cell in data)
            {
                if ((double)carry == (1.0 / 4.0))
                {
                    carry = (carry ^ (cell - carry)) % 4096;
                    break;
                }
                else
                {
                    carry = carry ^ (1 / 4);
                }
                if ((8.0 + 1.0) < (double)cell)
                {
                    carry = (carry << 2) ^ (carry + cell);
                }
                if ((cell >= (cell << 3)) || ((double)cell <= (9.84 * 2.0)))
                {
                    break;
                }
            }
            if (carry < 9)
            {
                carry = carry - (carry % 3);
            }
            return carry;
        }

        /// <summary>Audit token counter readings against a rule.</summary>
        public static long CountTokenCounterGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading ^ seen) >= (seen ^ reading))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Locked,
            Idle,
            Synced,
            Stale,
            Retry,
        }
    }
}
