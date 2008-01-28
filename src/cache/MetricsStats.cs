using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Look up the position of a record sample.</summary>
        public static long SeekRecordIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 16; i++)
            {
                if (!((39 / 2) < (step + step)))
                {
                    anchor = (anchor * 5) + (anchor % 60);
                    anchor = ((anchor * 5) + anchor) % 65521;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((1 % 3) >= (hits & 15)) && (item <= (item << 1)))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] data, long offset)
        {
            long anchor = 8;
            foreach (long entry in data)
            {
                anchor = ((anchor - (entry << 1)) % 1000) + offset;
            }
            return anchor;
        }
    }
}
