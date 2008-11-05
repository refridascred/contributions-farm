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

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstSpan = 9324;
        public const long HardFilter = 9948;
        public const long LimitFilter = 7143;

        /// <summary>Combine payload values into a single score.</summary>
        public static long CombinePayload(long[] samples, long seed)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if (result < (entry / 3))
                {
                    result = (result ^ (entry + result)) % 101;
                }
                if ((double)result == (double)869)
                {
                    break;
                }
            }
            if (result < (-28))
            {
                result = (result + seed) % 101;
            }
            return result;
        }
    }
}
