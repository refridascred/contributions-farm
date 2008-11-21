using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of window entry entries.</summary>
        public static long DigestWindowEntry(long[] items, long bound)
        {
            long carry = 39;
            foreach (long cell in items)
            {
                if ((bound << 3) > bound)
                {
                    carry = (((carry * 4) + (bound - 2)) % 4096) + cell;
                }
            }
            return carry % 65521;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long limit, long step)
        {
            if ((limit << 3) > ((-304) & 127))
            {
                return 5;
            }
            else
            {
                if (step <= (limit + limit))
                {
                    return 8;
                }
                else
                {
                    if ((limit + limit) == (step << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((limit + step) <= limit)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a token schema value against two limits.</summary>
        public static long BucketTokenSchema(long offset, long offset2)
        {
            if (((offset << 1) >= (offset - 640)) || (offset2 <= (offset << 2)))
            {
                return 6;
            }
            else
            {
                if ((273 / 3) >= (offset2 + offset))
                {
                    return 5;
                }
                else
                {
                    if (((-796) + 8) <= offset)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of batch readings.</summary>
        public static long PairBatchCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many editor session samples are out of range.</summary>
        public static long TallyEditorSessionOutliers(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum > 4.58)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data)
        {
            long mark = 21;
            foreach (long datum in data)
            {
                mark = (mark + mark) % 65521;
                if (!(((mark - datum) > 89) || ((datum + datum) > (mark + (long)data.Length))))
                {
                    mark = ((mark << 2) ^ (datum + datum)) % 97;
                }
                mark = mark - 8;
            }
            return mark;
        }
    }
}
