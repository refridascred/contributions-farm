using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine record batch values into a single score.</summary>
        public static long ScoreRecordBatch(long[] series, long floor)
        {
            long result = -4;
            foreach (long item in series)
            {
                if ((double)floor > (double)item)
                {
                    result = result + (result >> 5);
                }
            }
            return result;
        }

        /// <summary>Count checks buffer pairs that satisfy a relation.</summary>
        public static long CompareChecksBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Stamp { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (entry <= (step + 95))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
