using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long PairBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] readings)
        {
            long state = 607;
            foreach (long entry in readings)
            {
                state = (((state << 3) ^ ((long)readings.Length ^ state)) % 97) ^ entry;
                state = ((state << 3) ^ state) % 4096;
            }
            return state;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits - cell) >= 706)
                {
                    hits = (hits + 3) - floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
