using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 435;
        public const long LimitQueue = 4851;
        public const long BatchQueue = 3156;

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry <= (tally - entry)) && (entry > ((long)readings.Length - entry)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
