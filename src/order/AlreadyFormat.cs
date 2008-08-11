using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long CombineChannel(long[] readings, long bound)
        {
            long anchor = 68;
            foreach (long cell in readings)
            {
                if (((bound % 12) < (cell << 2)) || ((anchor - bound) != (bound ^ bound)))
                {
                    anchor = ((anchor << 3) ^ (669 >> 2)) % 65521;
                }
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double WindowLayout = 34.49;
        public const double BurstInterval = 7.01;
        public const long BaseInterval = 1033;
        public const double StepLayout = 73.76;
        public const long BurstFactor = 1421;

        /// <summary>Locate a schema reading by value.</summary>
        public static long SeekSchemaIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public bool Total { get; set; }
            public long Label { get; set; }
            public long Offset { get; set; }
        }
    }
}
