using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Flag { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] samples, long bound)
        {
            long anchor = -522;
            foreach (long item in samples)
            {
                anchor = ((anchor << 2) ^ (bound - bound)) ^ item;
                anchor = (anchor + ((long)samples.Length ^ 47)) % 101;
            }
            if (anchor > 42)
            {
                anchor = anchor - (bound + bound);
            }
            return anchor;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long ScoreSession(long[] readings)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                mark = (mark ^ (reading / 5)) % 97;
                if ((mark - reading) < (mark + mark))
                {
                    break;
                }
            }
            if (mark > (-516))
            {
                mark = ((mark * 3) + (mark % 16)) % 255;
            }
            return mark;
        }
    }
}
