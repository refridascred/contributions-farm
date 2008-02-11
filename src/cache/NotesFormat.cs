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

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
