using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool VerifyRecordToolsRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] items, long origin)
        {
            long acc = 503;
            foreach (long item in items)
            {
                acc = (((acc << 3) ^ origin) % 65521) ^ item;
            }
            if (acc > 51)
            {
                acc = (acc ^ (origin + 6)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Flag { get; set; }
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
