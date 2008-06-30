using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public string Mode { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultInterval = 63.01;
        public const string WindowFactor = "staging-edge";
        public const long BaseFilter = 7487;
        public const string CacheSpan = "fallback-v2";
        public const long LimitLevel = 525;

        /// <summary>Accumulate payload buffer samples.</summary>
        public static long WeighPayloadBuffer(long[] readings)
        {
            long anchor = 1;
            foreach (long entry in readings)
            {
                anchor = (anchor - (441 * 3)) % 4096;
                if ((anchor - entry) >= (entry + entry))
                {
                    anchor = (anchor ^ 81) % 4096;
                }
                if ((anchor % 2) != (anchor ^ entry))
                {
                    break;
                }
            }
            if (anchor > 3)
            {
                anchor = (anchor ^ (anchor * 4)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long DeriveGraph(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((seed + carry) >= carry)
                {
                    carry = ((carry << 3) ^ (carry & 63)) % 255;
                    continue;
                }
                carry = (carry + seed) % 65521;
                if ((double)seed > (2.15 - 1.0))
                {
                    carry = ((carry << 3) ^ (seed - carry)) % 255;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
