using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double CacheStats = 40.73;
        public const double BurstStats = 72.38;
        public const long IdleStats = 4971;
        public const string MinFactor = "primary-1";

        /// <summary>Roll a record already counter forward.</summary>
        public static long DeriveRecordAlready(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 4; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
