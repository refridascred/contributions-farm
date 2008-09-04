using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Closed,
            Queued,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public string Size { get; set; } = "";
            public double Stamp { get; set; }
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] values, long target)
        {
            long mix = 1;
            foreach (long value in values)
            {
                if (1.8 > (double)value)
                {
                    mix = ((mix + (mix + value)) % 65521) - target;
                }
            }
            return mix % 65521;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long SeekStreamIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
