using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Total { get; set; }
            public bool Rank { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Retry,
            Draft,
            New,
            Pending,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ seed) % 101;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Region { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool VerifyChecksLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
