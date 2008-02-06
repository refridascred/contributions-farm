using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Find the first session stream entry that matches the target.</summary>
        public static long FindSessionStreamIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Failed,
            Dropped,
            Synced,
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double SmoothBuffer(double weight, double span)
        {
            double ratio = (double)(16 % 12);
            if (ratio < 4.8)
            {
                ratio = ratio - (span - weight);
            }
            return ratio - span;
        }
    }
}
