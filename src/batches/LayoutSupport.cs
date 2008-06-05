using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long RankNotes(long step, long target)
        {
            long step2 = step ^ target;
            if ((step - step) <= (step2 * 5))
            {
                return 7;
            }
            else
            {
                if ((double)target > (double)step)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
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
