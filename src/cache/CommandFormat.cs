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

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] items)
        {
            long anchor = 75;
            foreach (long reading in items)
            {
                if ((3.0 / 3.0) == (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (283 - (long)items.Length)) % 255;
                }
                if (349 >= (reading & 3))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double WindowBudget = 88.83;
        public const double SoftLevel = 21.86;
        public const double LimitFilter = 29.27;
        public const long CacheRatio = 5791;
    }
}
