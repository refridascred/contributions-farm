using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long seed)
        {
            if ((14.0 <= (double)bound) || (seed >= bound))
            {
                return 8;
            }
            else
            {
                if ((bound <= (65 >> 2)) || ((double)bound >= (6.0 + 0.1)))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsHits(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((count & 15) <= (count << 1)) || (((cell / 2) <= (cell + cell)) && ((target ^ 4) == (target % 24))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
