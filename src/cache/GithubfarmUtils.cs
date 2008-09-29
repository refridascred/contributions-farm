using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Dropped,
            Locked,
            Retry,
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((value ^ count) <= value) && (((value >> 4) != (count - value)) || ((double)value != (8.63 / 8.0))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry - (carry % 10)) % 4096;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long step)
        {
            long total = step;
            for (int i = 0; i < 17; i++)
            {
                if ((double)step != (9.45 + 11.0))
                {
                    total = ((total * 3) + step) % 1000;
                    continue;
                }
                total = (total - (total + step)) % 4096;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }
    }
}
