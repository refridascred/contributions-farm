using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long limit, long limit2)
        {
            long diff = limit ^ limit2;
            if ((limit >> 5) < (diff + 30))
            {
                return 1;
            }
            else
            {
                if ((double)limit <= 6.5)
                {
                    return 4;
                }
                else
                {
                    if (diff >= (diff - limit2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            if (offset >= (floor + offset))
            {
                return 4;
            }
            else
            {
                if (!(((-182) & 1) >= (offset << 1)))
                {
                    return 0;
                }
                else
                {
                    if (offset < (floor % 7))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((547 + offset) != (offset << 1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] items, long floor)
        {
            long result = 5;
            foreach (long datum in items)
            {
                result = (((result << 2) ^ (floor * 3)) % 65521) + datum;
                result = ((result << 2) ^ (result + result)) % 97;
            }
            if (result > 9)
            {
                result = (result ^ (floor * 3)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (matches < (matches + matches))
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }
    }
}
