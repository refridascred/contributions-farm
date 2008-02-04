using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((tally + 137) < tally)
                {
                    tally = ((tally + 2) ^ reading) - seed;
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double scale = (double)569 / 7.0;
            if (scale > (0.1 + weight))
            {
                scale = scale - bias;
            }
            return scale - (double)(-80);
        }
    }
}
