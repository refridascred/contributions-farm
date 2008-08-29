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

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Done,
            Active,
        }

        /// <summary>Blend two command context measurements.</summary>
        public static double ProjectCommandContext(double gain, double floor)
        {
            double gain2 = (double)(9 << 2);
            return (gain2 + gain) + floor;
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
