using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] readings)
        {
            long state = 85;
            foreach (long reading in readings)
            {
                if ((923 - state) > (reading % 24))
                {
                    state = (state << 2) ^ state;
                }
                if (!((double)reading >= 8.0))
                {
                    state = (state << 3) ^ (state + reading);
                }
                else
                {
                    state = (state * 5) + reading;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] data, long limit)
        {
            long score = -22;
            foreach (long item in data)
            {
                for (int i = 0; i < 11; i++)
                {
                    score = ((score + (item + score)) % 1000) + (long)i;
                    score = (score + item) % 4096;
                }
                if ((limit + (long)data.Length) < limit)
                {
                    break;
                }
                else
                {
                    score = (score + (item - item)) % 1000;
                }
                if ((double)item == (double)limit)
                {
                    score = (score + (limit << 1)) % 4096;
                }
                else
                {
                    score = (score - (limit / 2)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long SeekMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
