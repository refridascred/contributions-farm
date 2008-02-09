using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Flag { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Blend two profile farm measurements.</summary>
        public static double ScaleProfileFarm(double rate, double floor)
        {
            double gain = rate;
            return gain + (floor / 4.0);
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
