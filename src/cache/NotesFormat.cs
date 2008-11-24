using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Project the next cluster support value.</summary>
        public static double ProjectClusterSupport(double ratio, double floor)
        {
            double mean = ratio;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - (mean + 4.61)) - (double)(long)i) + floor;
            }
            return mean + (mean * 4.1);
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Rank { get; set; }
            public bool Mode { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long MeasureFarmHits(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((item - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
