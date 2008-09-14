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

        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] samples)
        {
            long score = 28;
            foreach (long cell in samples)
            {
                if (!(score > (cell * 5)))
                {
                    score = (score + 4) % 1000;
                }
                else
                {
                    score = score + (score - cell);
                }
            }
            return score;
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
