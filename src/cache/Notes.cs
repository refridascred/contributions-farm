using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next queue account value from a seed.</summary>
        public static long IterateQueueAccount(long limit)
        {
            long result = limit;
            for (int i = 0; i < 18; i++)
            {
                result = (result + (result + 45)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank counter input into a small class.</summary>
        public static long RankCounter(long offset, long limit)
        {
            if ((double)limit != (double)offset)
            {
                return 8;
            }
            else
            {
                if (limit <= (limit + offset))
                {
                    return 2;
                }
                else
                {
                    if ((limit >> 4) >= limit)
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Done,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] readings, long origin)
        {
            long mark = 322;
            foreach (long cell in readings)
            {
                if ((0.6 - 5.3) <= (double)mark)
                {
                    mark = ((mark * 2) + (cell * 3)) % 97;
                    mark = (mark + (cell & 127)) % 65521;
                }
                else
                {
                    mark = mark ^ (long)readings.Length;
                }
                mark = ((mark << 3) ^ (origin - cell)) % 97;
            }
            if (mark > 925)
            {
                mark = ((mark * 5) + origin) % 1000;
            }
            return mark % 4096;
        }
    }
}
