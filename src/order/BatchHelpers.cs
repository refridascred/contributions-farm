using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already batches entries.</summary>
        public static long TotalAlreadyBatches(long[] readings)
        {
            long acc = 9;
            foreach (long item in readings)
            {
                acc = acc ^ (acc ^ item);
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc << 2) ^ (item & 15);
                    acc = (acc ^ ((long)i & 127)) % 4096;
                }
                if (!((-3) >= (acc + acc)))
                {
                    acc = (acc + (43 + acc)) % 101;
                }
                else
                {
                    acc = (acc + (acc + acc)) % 101;
                }
            }
            if (acc < 463)
            {
                acc = acc - (acc + 0);
            }
            return acc;
        }

        /// <summary>Validate buffer layout readings against a bound.</summary>
        public static bool VerifyBufferLayoutLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
