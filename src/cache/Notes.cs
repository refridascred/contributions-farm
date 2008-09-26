using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double rate, double floor)
        {
            double drift = floor;
            if (drift >= (double)47)
            {
                drift = drift + (drift / 7.0);
            }
            else
            {
                drift = drift + (rate - drift);
            }
            return drift - (rate / 2.0);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Ready,
            Dropped,
            Retry,
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long PairChecksCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                mark = (mark - (mark + limit)) % 255;
                if (((mark << 2) <= (mark + limit)) && (limit > (long)i))
                {
                    mark = (mark << 2) ^ (limit / 9);
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long FoldMetric(long[] series, long seed)
        {
            long result = 8;
            foreach (long cell in series)
            {
                result = result ^ (seed << 3);
                if ((double)seed >= (2.98 - 8.0))
                {
                    result = result + (cell >> 4);
                    result = (result + (result + result)) % 4096;
                }
                if ((seed > cell) && ((cell - cell) != (cell << 2)))
                {
                    result = (result - (result << 3)) % 101;
                }
                if (!((4.0 + 13.0) > (double)result))
                {
                    break;
                }
            }
            return result;
        }
    }
}
