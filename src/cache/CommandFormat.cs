using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long MeasureChannelHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((origin * 2) != ((long)readings.Length >> 3))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public long Total { get; set; }
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Fold a list of session channel readings.</summary>
        public static long WeighSessionChannel(long[] series, long limit)
        {
            long mix = -605;
            foreach (long item in series)
            {
                if (!((item - item) <= item))
                {
                    mix = ((mix << 3) ^ (limit & 3)) % 97;
                }
                if (!((item + mix) <= limit))
                {
                    mix = (mix ^ (mix >> 4)) % 255;
                }
                else
                {
                    mix = mix + (item - (long)series.Length);
                }
            }
            return mix;
        }
    }
}
