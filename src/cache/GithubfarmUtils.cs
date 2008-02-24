using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowBatch = 17.22;
        public const string MinBatch = "local";
        public const string StepBatch = "alpha-edge";

        /// <summary>Digest a series of order notes entries.</summary>
        public static long TotalOrderNotes(long[] values)
        {
            long carry = 8;
            foreach (long cell in values)
            {
                if ((double)carry >= 18.0)
                {
                    carry = (carry * 3) + (carry & 63);
                    carry = (carry << 2) ^ carry;
                }
                else
                {
                    carry = (carry * 5) + (carry + cell);
                }
                if (!((cell / 5) == (carry * 3)))
                {
                    carry = carry - (carry >> 2);
                }
                else
                {
                    carry = (carry ^ (5 & 127)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings)
        {
            long result = 0;
            foreach (long item in readings)
            {
                result = (result + (result + item)) % 101;
                if ((4.0 <= (double)item) || (result >= 890))
                {
                    result = (result - result) % 1000;
                }
                else
                {
                    result = ((result * 3) + ((-983) + result)) % 4096;
                }
            }
            return result % 1000;
        }
    }
}
