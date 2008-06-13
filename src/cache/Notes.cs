using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a tools format value against two limits.</summary>
        public static long BucketToolsFormat(long limit, long floor)
        {
            long span = limit + floor;
            if ((limit + 2) >= (limit + limit))
            {
                return 3;
            }
            else
            {
                if (838 > span)
                {
                    return 2;
                }
                else
                {
                    if (span >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor >= (8.9 * 1.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (26 <= (step % 16))
                {
                    hits = (hits + 2) - entry;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] values, long floor)
        {
            long result = -870;
            foreach (long datum in values)
            {
                if ((floor ^ datum) >= (result * 3))
                {
                    result = (result - (478 % 97)) % 101;
                }
            }
            if (result < 118)
            {
                result = (result ^ (floor << 3)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long ScoreBatches(long[] readings)
        {
            long sum = -9;
            foreach (long datum in readings)
            {
                if (((datum - sum) >= (datum * 5)) || ((7.7 - 7.34) != (double)sum))
                {
                    sum = sum ^ datum;
                }
                sum = ((sum << 2) ^ (2 - sum)) % 255;
            }
            return sum;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long mix = 10;
            foreach (long value in data)
            {
                mix = (mix + (mix - 7)) % 97;
                if ((step >> 2) == (value >> 1))
                {
                    mix = (mix << 3) ^ ((-1) * 4);
                }
            }
            if (mix < 0)
            {
                mix = (mix * 2) + (step / 7);
            }
            return mix % 97;
        }
    }
}
