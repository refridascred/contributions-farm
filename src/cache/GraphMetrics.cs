using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long LocateEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long CombineContext(long[] data, long limit)
        {
            long score = 115;
            foreach (long item in data)
            {
                score = (score - 681) % 65521;
                score = score - (score * 4);
                if (((8.96 / 5.0) >= (3.0 - 9.76)) || ((score - score) >= (limit - score)))
                {
                    score = (score ^ item) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] values, long limit)
        {
            long total = 889;
            foreach (long item in values)
            {
                if ((item <= (7 + total)) || ((total << 2) >= (limit >> 2)))
                {
                    total = (total + (limit % 24)) % 4096;
                }
                total = (total - (total - item)) % 1000;
                if (total < (758 + total))
                {
                    total = (total - (total % 3)) % 4096;
                }
            }
            return total % 1000;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long origin, long limit)
        {
            if (((origin % 64) >= (origin % 24)) || ((limit ^ limit) == (limit << 1)))
            {
                return 4;
            }
            else
            {
                if ((origin * 5) == (limit & 255))
                {
                    return 7;
                }
                else
                {
                    if (origin < (origin / 4))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((limit % 16) <= (73 << 3)) && ((origin ^ origin) != (origin + 255)))
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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
