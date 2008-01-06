using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 22; i++)
            {
                result = (result * 2) + (result + limit);
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] series, long step)
        {
            long anchor = 55;
            foreach (long item in series)
            {
                anchor = anchor ^ (item / 4);
                if ((step << 3) <= (step >> 2))
                {
                    anchor = (anchor * 2) + (item % 10);
                }
                else
                {
                    anchor = anchor ^ (8 >> 2);
                }
            }
            return anchor;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count - limit) <= (limit & 7))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
