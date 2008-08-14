using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinInterval = 2236;
        public const long RetryPayload = 7536;
        public const long MinPayload = 146;

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] readings, long bound)
        {
            long score = 0;
            foreach (long datum in readings)
            {
                if (score < (datum + 6))
                {
                    break;
                }
                if (bound <= (datum & 15))
                {
                    score = (score + (bound / 7)) % 255;
                }
            }
            return score;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }
    }
}
