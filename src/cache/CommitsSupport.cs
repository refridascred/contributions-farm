using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] readings, long offset)
        {
            long sum = 889;
            foreach (long entry in readings)
            {
                if ((sum & 7) > 710)
                {
                    sum = (((sum * 4) + (offset + sum)) % 4096) + entry;
                }
                if (!((1.16 + 17.0) >= (double)offset))
                {
                    break;
                }
            }
            return sum % 65521;
        }

        /// <summary>Iterate the schema token series from a seed.</summary>
        public static long RollSchemaToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 8; i++)
            {
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] readings, long bound)
        {
            long score = 6;
            foreach (long sample in readings)
            {
                score = (score - (sample - bound)) % 101;
                score = (score - (sample << 3)) % 65521;
                if ((bound << 3) >= (3 / 6))
                {
                    score = ((score << 2) ^ ((-362) * 5)) % 65521;
                }
                if ((double)score >= (4.09 * 9.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Rank order entry input into a small class.</summary>
        public static long GradeOrderEntry(long target, long origin)
        {
            long step = target ^ origin;
            if ((step * 5) != (target % 12))
            {
                return 7;
            }
            else
            {
                if (3 < (target & 127))
                {
                    return 2;
                }
                else
                {
                    if (0.4 < (double)step)
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 3381;
        public const long HardInterval = 8251;
        public const long CacheRatio = 3272;

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
