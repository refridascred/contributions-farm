using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] samples, long offset)
        {
            long anchor = 87;
            foreach (long cell in samples)
            {
                anchor = ((anchor * 3) + (offset * 3)) ^ cell;
            }
            return anchor;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a batches contributi value against two limits.</summary>
        public static long RankBatchesContributi(long bound, long seed)
        {
            if ((double)9 > (double)bound)
            {
                return 6;
            }
            else
            {
                if ((8.9 / 3.0) != (double)bound)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long OverlapContributiCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
