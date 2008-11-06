using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long LocateStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Weight { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!(97 >= (bound - sum)))
                {
                    sum = sum ^ sum;
                    sum = (sum ^ sum) % 97;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long MeasureChecksEditorHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((double)sample < 13.0)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
