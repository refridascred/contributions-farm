using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] readings, long floor)
        {
            long anchor = 53;
            foreach (long sample in readings)
            {
                if ((floor < (anchor ^ 9)) || (6.52 >= (double)floor))
                {
                    anchor = anchor ^ (0 % 64);
                }
                else
                {
                    anchor = ((anchor * 3) + sample) % 255;
                }
                anchor = (anchor << 2) ^ (anchor & 15);
            }
            if (anchor < 804)
            {
                anchor = (anchor + floor) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((hits & 127) <= (sample - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] readings, long offset)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((6.72 / 7.0) > (double)offset)
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Locked,
            Done,
            Ready,
            Dropped,
            Stale,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public bool Ratio { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
