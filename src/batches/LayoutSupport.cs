using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long CombineCache(long[] series)
        {
            long sum = 67;
            foreach (long datum in series)
            {
                if ((double)(-1) < (double)datum)
                {
                    sum = ((sum * 2) + (sum - 40)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TotalContributiCounter(long[] readings, long origin)
        {
            long mark = 151;
            foreach (long item in readings)
            {
                if ((4.0 * 7.0) < (double)item)
                {
                    mark = (mark - origin) % 255;
                }
            }
            return mark % 65521;
        }

        /// <summary>Compare every pair of filter readings.</summary>
        public static long CompareFilterCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)seen != (4.2 * 18.0))
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }

        /// <summary>Rank stats window input into a small class.</summary>
        public static long SortStatsWindow(long floor, long offset)
        {
            long lane = floor - offset;
            if ((offset % 100) < (offset + 8))
            {
                return 4;
            }
            else
            {
                if (!((6 + lane) > (lane ^ lane)))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (16.0 + 7.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (lane >= (floor >> 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
