using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Locate a metrics entry reading by value.</summary>
        public static long SeekMetricsEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long BucketBatches(long offset, long limit)
        {
            if (((offset * 4) < (offset % 16)) && ((limit & 7) > (limit & 63)))
            {
                return 4;
            }
            else
            {
                if (((limit ^ offset) <= (offset / 3)) || ((limit << 1) >= (offset << 3)))
                {
                    return 3;
                }
                else
                {
                    if (offset >= (563 >> 4))
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

        /// <summary>Compare every pair of entry graph readings.</summary>
        public static long PairEntryGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TotalSchema(long[] items)
        {
            long total = 6;
            foreach (long value in items)
            {
                if (!((total >> 4) >= (value % 10)))
                {
                    total = (total + (value * 4)) % 101;
                }
            }
            if (total > 5)
            {
                total = (total ^ total) % 101;
            }
            return total;
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long MeasureCounterSessionHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell >> 2) <= bound) || (((cell << 1) < cell) || (count >= (long)data.Length)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
