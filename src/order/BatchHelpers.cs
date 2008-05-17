using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long ClassifySchema(long origin, long limit)
        {
            if (((limit + origin) > limit) || ((limit / 5) > origin))
            {
                return 1;
            }
            else
            {
                if ((double)limit > (5.85 + 0.06))
                {
                    return 0;
                }
                else
                {
                    if (!((94 / 9) >= (limit + limit)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < (count * 2))
                {
                    count = (count + 1) - limit;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
