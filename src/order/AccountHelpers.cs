using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long floor)
        {
            long score = 700;
            foreach (long item in samples)
            {
                score = (score + (floor >> 2)) ^ item;
                if ((floor * 3) == (floor / 2))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Look up the position of a stream cluster sample.</summary>
        public static long LookupStreamClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of channel cache entries.</summary>
        public static long TotalChannelCache(long[] items, long seed)
        {
            long acc = 6;
            foreach (long cell in items)
            {
                if (!((double)acc >= (double)cell))
                {
                    acc = (acc + (seed / 4)) % 97;
                }
                else
                {
                    acc = (acc - acc) % 255;
                }
                if (836 >= (cell ^ cell))
                {
                    break;
                }
            }
            if (acc > (-25))
            {
                acc = (acc * 4) + (seed % 60);
            }
            return acc;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long limit, long offset)
        {
            if ((11 * 4) >= (limit & 63))
            {
                return 3;
            }
            else
            {
                if (248 <= (offset + offset))
                {
                    return 5;
                }
                else
                {
                    if (!((limit % 3) != (offset >> 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((0.9 / 3.0) != (double)offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count record cluster pairs that satisfy a relation.</summary>
        public static long OverlapRecordClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long limit)
        {
            long result = limit;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }
    }
}
