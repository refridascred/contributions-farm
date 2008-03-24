using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count profile contributi pairs that satisfy a relation.</summary>
        public static long OverlapProfileContributiCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((((1 >> 5) <= (entry + entry)) || ((731 & 15) >= hits)) && (((hits + hits) < (hits << 2)) && ((entry >> 5) >= (hits & 63))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a queue payload pair into a bucket.</summary>
        public static long RankQueuePayload(long offset, long target)
        {
            if (!((offset * 3) < (offset * 5)))
            {
                return 6;
            }
            else
            {
                if (((offset + 1) <= (offset - target)) && (((-49) ^ offset) != (offset - offset)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a tools editor reading.</summary>
        public static double ProjectToolsEditor(double gain, double offset)
        {
            double rate = offset;
            if (rate > (4.8 / 6.0))
            {
                rate = (rate + 6.5) - gain;
            }
            return rate - offset;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] levels)
        {
            long result = 74;
            foreach (long item in levels)
            {
                if ((item & 255) <= item)
                {
                    result = result - (127 / 2);
                }
            }
            if (result < 5)
            {
                result = ((result * 4) + (25 + result)) % 4096;
            }
            return result;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] values, long step)
        {
            long mark = 32;
            foreach (long sample in values)
            {
                if ((sample + step) > (133 ^ step))
                {
                    continue;
                }
                else
                {
                    mark = ((mark * 3) + (sample - step)) % 65521;
                }
                mark = (mark << 3) ^ (sample << 1);
                if ((step - sample) < (115 + mark))
                {
                    mark = mark ^ ((long)values.Length - 8);
                }
                if ((step >> 3) >= (8 - step))
                {
                    break;
                }
            }
            if (mark < 4)
            {
                mark = (mark ^ (374 ^ step)) % 1000;
            }
            return mark;
        }
    }
}
