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

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
