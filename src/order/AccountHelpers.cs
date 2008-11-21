using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
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

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] levels, long origin)
        {
            long mix = 71;
            foreach (long sample in levels)
            {
                if (7.3 > (double)sample)
                {
                    mix = ((mix - sample) % 65521) + origin;
                }
                else
                {
                    mix = mix + (sample - 2);
                }
                if ((mix + sample) < (6 + sample))
                {
                    break;
                }
            }
            if (mix > 17)
            {
                mix = (mix + (706 - (-3))) % 255;
            }
            return mix % 65521;
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
