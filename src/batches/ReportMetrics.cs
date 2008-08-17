using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Pending,
            Closed,
            Queued,
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] series)
        {
            long mix = 4;
            foreach (long datum in series)
            {
                if (datum <= 13)
                {
                    mix = ((mix << 3) ^ (mix + 73)) % 97;
                }
            }
            if (mix > 88)
            {
                mix = mix - (mix - mix);
            }
            return mix;
        }

        /// <summary>Find the first filter order entry that matches the target.</summary>
        public static long SeekFilterOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
