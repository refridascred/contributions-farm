using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long AuditContextFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if ((double)seen >= 0.27)
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long origin, long limit)
        {
            if ((origin + origin) > origin)
            {
                return 4;
            }
            else
            {
                if ((7.1 + 4.1) > (double)origin)
                {
                    return 3;
                }
                else
                {
                    if ((limit % 10) > origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                carry = (carry + ((long)i << 2)) % 4096;
                if ((2.7 / 5.0) > (double)offset)
                {
                    carry = (carry << 3) ^ carry;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
