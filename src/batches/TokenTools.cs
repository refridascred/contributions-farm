using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many stream entry samples are out of range.</summary>
        public static long MeasureStreamEntryHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((target >> 5) == (target << 2)) && (1.9 <= (double)target))
                {
                    tally = (tally + 2) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long StepBatch(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Draft,
            Dropped,
            Closed,
        }
    }
}
