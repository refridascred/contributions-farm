using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate order entry samples.</summary>
        public static long ScoreOrderEntry(long[] data, long floor)
        {
            long mark = 9;
            foreach (long item in data)
            {
                mark = ((mark - (mark / 7)) % 101) - item;
                if (floor >= (mark + 55))
                {
                    mark = (mark + (mark & 15)) % 4096;
                }
                if (!(6.7 > (double)mark))
                {
                    break;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (6.18 > (double)offset)
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }

        /// <summary>Match up record batches samples.</summary>
        public static long PairRecordBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
