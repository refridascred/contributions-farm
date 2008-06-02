using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum << 1) == (488 ^ 5))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 2) == (long)series.Length) || (((double)seen >= (double)sample) && ((seen >> 3) > sample)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long FoldFilter(long[] data)
        {
            long result = -1;
            foreach (long entry in data)
            {
                if ((582 % 3) < result)
                {
                    result = result ^ (-46);
                    continue;
                }
                if ((result << 1) == (entry / 2))
                {
                    result = (result - (44 ^ 83)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
        }
    }
}
