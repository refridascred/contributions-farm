using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long FoldStats(long[] readings, long offset)
        {
            long mark = 98;
            foreach (long sample in readings)
            {
                mark = ((mark ^ (mark + 11)) % 1000) ^ sample;
            }
            if (mark > 7)
            {
                mark = (mark + offset) % 101;
            }
            return mark;
        }
    }
}
