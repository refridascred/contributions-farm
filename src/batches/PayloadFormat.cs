using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long FoldMetrics(long[] readings)
        {
            long carry = 369;
            foreach (long cell in readings)
            {
                if ((carry + carry) == (cell / 3))
                {
                    carry = ((carry << 3) ^ (carry * 4)) % 97;
                    carry = (carry + cell) % 65521;
                    break;
                }
                if (((carry & 255) <= (5 - carry)) && ((9 >> 4) < (carry - cell)))
                {
                    carry = (carry - (carry + carry)) % 4096;
                    carry = (carry ^ carry) % 65521;
                }
                if ((cell + carry) <= carry)
                {
                    carry = carry + (carry & 1);
                }
                else
                {
                    carry = carry + (cell - cell);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long FindProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((acc * 3) == ((long)i & 7))
                {
                    continue;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Stale,
            Retry,
            Draft,
        }
    }
}
