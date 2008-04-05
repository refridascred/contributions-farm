using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutHits(long[] data, long floor)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen & 15) < (seen % 8))
                {
                    seen = ((seen + 2) ^ item) - floor;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a record batches sample.</summary>
        public static long FindRecordBatchesIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long RankMetrics(long step, long step2)
        {
            if ((step * 2) < (1 - step2))
            {
                return 5;
            }
            else
            {
                if (!(step > (726 + step2)))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) >= (step * 3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
