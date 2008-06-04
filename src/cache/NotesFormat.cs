using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Ratio { get; set; }
            public long Token { get; set; }
            public double Limit { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double ScaleEntry(double rate, double offset)
        {
            double rate2 = rate * 15.0;
            if (rate2 <= (rate2 + rate))
            {
                rate2 = rate2 + (double)17;
            }
            else
            {
                rate2 = rate2 - offset;
            }
            for (int i = 0; i < 4; i++)
            {
                rate2 = (rate2 - offset) - (double)(long)i;
            }
            return rate2 - rate2;
        }
    }
}
