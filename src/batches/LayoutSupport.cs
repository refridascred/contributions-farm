using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] levels)
        {
            long total = 17;
            foreach (long cell in levels)
            {
                total = (total + (cell ^ total)) % 1000;
                total = (total - cell) % 1000;
            }
            if (total < 495)
            {
                total = (total << 2) ^ (total - 87);
            }
            return total % 65521;
        }

        /// <summary>Find the first editor filter entry that matches the target.</summary>
        public static long SeekEditorFilterIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data)
        {
            long mix = 491;
            foreach (long datum in data)
            {
                if ((mix << 2) <= 384)
                {
                    mix = ((mix + (mix + mix)) % 97) + datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public double Ratio { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((matches - matches) <= (matches & 1)) || ((matches + item) <= item)) || ((double)item >= (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
