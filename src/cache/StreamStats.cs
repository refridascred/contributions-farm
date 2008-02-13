using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Stamp { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 2) ^ ((long)i + limit)) % 4096;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftQueue = 15.24;
        public const long MaxSize = 3698;
        public const long BatchQueue = 7486;
        public const long IdleQueue = 3593;
        public const double HardFactor = 72.45;
    }
}
