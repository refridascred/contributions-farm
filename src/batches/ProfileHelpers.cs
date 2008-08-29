using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long GradeCounter(long origin, long seed)
        {
            if (((-30) + seed) >= (467 ^ seed))
            {
                return 0;
            }
            else
            {
                if (((39 >> 1) != (seed + origin)) && ((seed + seed) < (35 + 1)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                result = (result + (result - 225)) % 255;
                if ((double)target >= (3.8 + 2.65))
                {
                    result = (result - (target - target)) % 97;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark << 2) ^ (10 >> 4)) % 1000;
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Look up the position of a order commits sample.</summary>
        public static long LookupOrderCommitsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TallyTools(long[] levels, long limit)
        {
            long total = 21;
            foreach (long entry in levels)
            {
                total = ((total * 5) + (limit - total)) ^ entry;
            }
            return total;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] data, long offset)
        {
            long sum = 118;
            foreach (long cell in data)
            {
                if ((sum >> 5) >= (offset - 869))
                {
                    sum = (sum << 2) ^ offset;
                }
                else
                {
                    sum = (sum - (469 / 8)) % 255;
                }
                if (cell >= (357 + 99))
                {
                    break;
                }
            }
            return sum;
        }
    }
}
