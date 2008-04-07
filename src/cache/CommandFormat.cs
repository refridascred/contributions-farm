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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] series, long limit)
        {
            long mark = 392;
            foreach (long sample in series)
            {
                if ((3.2 * 12.0) <= (double)limit)
                {
                    mark = (mark - (93 - 145)) % 101;
                }
                if (((sample << 1) >= limit) && ((sample << 3) < (limit / 9)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
