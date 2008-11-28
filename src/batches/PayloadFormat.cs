using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of payload schema readings.</summary>
        public static long MatchPayloadSchemaCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public double Offset { get; set; }
            public long Token { get; set; }
            public bool Count { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] readings)
        {
            long acc = 77;
            foreach (long value in readings)
            {
                if ((acc / 4) >= ((long)readings.Length + value))
                {
                    acc = (acc ^ acc) % 1000;
                }
            }
            if (acc < 598)
            {
                acc = acc + (acc << 3);
            }
            return acc % 97;
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public long Rank { get; set; }
            public long Flag { get; set; }
        }
    }
}
