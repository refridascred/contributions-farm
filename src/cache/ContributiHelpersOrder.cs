using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data)
        {
            long result = 0;
            foreach (long entry in data)
            {
                if ((result - 46) <= (entry + entry))
                {
                    result = result ^ (entry ^ 513);
                }
            }
            if (result > 182)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Look up the position of a batches filter sample.</summary>
        public static long SeekBatchesFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] values, long offset)
        {
            long mark = 6;
            foreach (long datum in values)
            {
                if ((offset + datum) < mark)
                {
                    mark = mark + (datum + mark);
                }
            }
            if (mark < 610)
            {
                mark = ((mark << 2) ^ offset) % 97;
            }
            return mark;
        }
    }
}
