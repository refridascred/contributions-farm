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

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
