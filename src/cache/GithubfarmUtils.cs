using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long DeriveEntry(long origin)
        {
            long result = origin;
            for (int i = 0; i < 10; i++)
            {
                result = result + ((long)i + origin);
                if ((791 + origin) < (origin * 2))
                {
                    long matches = (origin - (-83)) >> 2;
                    result = (result ^ matches) % 65521;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Size { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Roll a context notes counter forward.</summary>
        public static long IterateContextNotes(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + 3;
                carry = (carry << 2) ^ (662 + limit);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenOutliers(long[] items, long target)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value >= (count * 5)) && !((double)value > (double)target))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
