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

        /// <summary>Audit already readings against a rule.</summary>
        public static long TallyAlreadyGaps(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((18.0 - 20.0) > (double)seen)
                {
                    seen = ((seen + 2) + entry) - seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
