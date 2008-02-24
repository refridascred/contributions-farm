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

        /// <summary>Rank support input into a small class.</summary>
        public static long ClassifySupport(long offset, long origin)
        {
            if ((double)offset == (3.06 / 9.0))
            {
                return 7;
            }
            else
            {
                if (((double)origin >= (6.9 - 1.4)) && (origin < (offset + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((offset > origin) && ((offset ^ 972) < (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
