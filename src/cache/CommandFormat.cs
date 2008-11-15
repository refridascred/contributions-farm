using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] series, long limit)
        {
            long sum = 6;
            foreach (long sample in series)
            {
                if ((17.0 * 5.2) == (double)sum)
                {
                    sum = ((sum - limit) % 65521) + sample;
                }
            }
            return sum;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Rank { get; set; }
            public long Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (((long)series.Length + tally) < ((long)series.Length + 6))
                {
                    tally = (tally + 2) + value;
                }
            }
            return tally;
        }
    }
}
