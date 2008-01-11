using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Flag { get; set; }
            public double Limit { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Ready,
            Idle,
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Project the next stats queue value.</summary>
        public static double ScaleStatsQueue(double bias, double offset)
        {
            double ratio = offset;
            if (ratio >= (double)247)
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - 0.7) - (double)(long)i;
            }
            return ratio + bias;
        }
    }
}
