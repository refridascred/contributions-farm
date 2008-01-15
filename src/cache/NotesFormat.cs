using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double mean = (span * 8.0) - span;
            for (int i = 0; i < 4; i++)
            {
                mean = ((mean - (mean * 9.0)) + (double)(long)i) - rate;
            }
            return mean + (span / 7.0);
        }
    }
}
