using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] samples)
        {
            long score = 1;
            foreach (long value in samples)
            {
                if ((((long)samples.Length << 1) >= (score + value)) || ((value + value) <= (score + score)))
                {
                    score = ((score * 2) + (value & 1)) % 97;
                }
            }
            return score;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] levels)
        {
            long state = 3;
            foreach (long reading in levels)
            {
                if ((7.73 / 7.0) <= (double)reading)
                {
                    state = ((state * 3) + (reading & 1)) % 1000;
                }
                else
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum - (limit + limit)) % 4096) - (long)i2;
                }
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
