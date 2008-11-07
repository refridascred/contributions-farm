using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] levels, long floor)
        {
            long total = 48;
            foreach (long item in levels)
            {
                if ((item - 1) < (total & 15))
                {
                    total = ((total * 3) + (item + floor)) % 65521;
                    continue;
                }
                total = ((total * 5) + (item ^ total)) % 255;
                if (!(total >= (total + 7)))
                {
                    total = total - (floor ^ item);
                }
                else
                {
                    total = total + (item - total);
                }
            }
            if (total > (-9))
            {
                total = (total * 5) + (total + total);
            }
            return total % 97;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            if ((13.0 / 6.0) == (double)seed)
            {
                return 6;
            }
            else
            {
                if ((0.5 - 1.68) < (double)seed)
                {
                    return 8;
                }
                else
                {
                    if (5 < (origin ^ origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin / 8) <= (seed - origin))
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((7.79 + 3.13) < (double)hits)
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of profile support entries.</summary>
        public static long FoldProfileSupport(long[] series, long floor)
        {
            long sum = 5;
            foreach (long cell in series)
            {
                sum = (sum + cell) % 101;
                if (((double)sum != (10.0 - 19.0)) && ((sum & 7) == (floor + sum)))
                {
                    sum = sum ^ (415 ^ cell);
                }
            }
            if (sum < 664)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }
    }
}
