using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] data, long limit)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + limit) < limit)
                {
                    tally = (tally + 3) - cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long CombineFilter(long[] readings, long origin)
        {
            long total = -96;
            foreach (long entry in readings)
            {
                total = (total + (origin + 0)) + entry;
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double bias)
        {
            double scale = gain * 11.0;
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (scale + 7.0)) + (double)(long)i) - bias;
            }
            return scale + (double)7;
        }
    }
}
