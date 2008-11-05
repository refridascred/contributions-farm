using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Mode { get; set; } = "";
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] data, long origin)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (origin < (seen - item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((1 << 1) == (seen / 6))
                {
                    seen = ((seen + 2) ^ item) + floor;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
