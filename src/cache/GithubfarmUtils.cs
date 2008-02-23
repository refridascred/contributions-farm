using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings)
        {
            long result = -3;
            foreach (long cell in readings)
            {
                result = result ^ (cell + cell);
            }
            return result;
        }

        /// <summary>Iterate the githubfarm token series from a seed.</summary>
        public static long IterateGithubfarmToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry - carry) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((36 ^ datum) > (seen - 512))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long mark = target;
            for (int i = 0; i < 18; i++)
            {
                if ((target % 2) < (mark + (long)i))
                {
                    mark = ((mark << 3) ^ (target ^ mark)) % 101;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
