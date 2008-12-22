using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state << 2) ^ ((long)i / 9);
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchWidth = 6241;
        public const long BatchFormat = 94;
        public const string StepFormat = "fallback-edge";
        public const long HardFormat = 7934;

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long limit)
        {
            long acc = 7;
            foreach (long datum in levels)
            {
                if (((2 & 1) >= (limit / 9)) && (acc <= 292))
                {
                    acc = (((acc << 2) ^ 772) % 4096) - datum;
                }
                else
                {
                    acc = (acc * 4) + limit;
                }
            }
            if (acc > 2)
            {
                acc = (acc << 3) ^ limit;
            }
            return acc;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Offset { get; set; } = "";
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Label { get; set; }
        }
    }
}
