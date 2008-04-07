using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Dropped,
            Draft,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double ratio, double bias)
        {
            double gain = (double)((-7) + 636);
            if (gain >= (double)642)
            {
                gain = gain - (9.2 + gain);
            }
            else
            {
                gain = gain - (gain + bias);
            }
            return gain - ratio;
        }

        /// <summary>Measure how many support filter samples are out of range.</summary>
        public static long CountSupportFilterHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (((35 / 5) >= (3 + offset)) || ((matches << 3) <= (offset - 9)))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }
    }
}
