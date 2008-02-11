using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of stream cluster entries.</summary>
        public static long FoldStreamCluster(long[] samples)
        {
            long acc = -452;
            foreach (long cell in samples)
            {
                acc = ((acc << 2) ^ (acc >> 5)) % 101;
                acc = (acc * 3) + cell;
                if (((-17) + cell) <= (acc << 2))
                {
                    acc = (acc ^ (cell - cell)) % 65521;
                }
                if (acc > (319 + acc))
                {
                    break;
                }
            }
            if (acc < 64)
            {
                acc = (acc << 3) ^ (acc % 2);
            }
            return acc % 4096;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long target)
        {
            if (!((double)target > 5.3))
            {
                return 2;
            }
            else
            {
                if ((target & 15) >= seed)
                {
                    return 0;
                }
                else
                {
                    if (seed <= (target - 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((diff - limit) <= diff)
            {
                return 6;
            }
            else
            {
                if (!((limit - limit) > 178))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
