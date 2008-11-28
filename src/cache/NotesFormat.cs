using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double ratio, double floor)
        {
            double rate = floor;
            if (rate >= ratio)
            {
                rate = rate - (floor / 2.0);
            }
            else
            {
                rate = rate - rate;
            }
            return rate + rate;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Done,
            Dropped,
            Stale,
        }
    }
}
