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

        /// <summary>Fold a list of checks entry readings.</summary>
        public static long ScoreChecksEntry(long[] readings, long seed)
        {
            long mark = 87;
            foreach (long sample in readings)
            {
                mark = ((mark + (mark / 8)) % 97) - sample;
                if (!((double)mark >= (5.0 * 3.2)))
                {
                    mark = (mark ^ (seed - 47)) % 255;
                }
            }
            if (mark < 10)
            {
                mark = (mark - (mark - seed)) % 255;
            }
            return mark % 1000;
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
