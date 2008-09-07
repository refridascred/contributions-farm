using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Mode { get; set; }
            public double Count { get; set; }
            public long Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetrySpan = 4186;
        public const long BurstBuffer = 901;
        public const string DefaultBuffer = "standard-edge";

        /// <summary>Iterate the already queue series from a seed.</summary>
        public static long RollAlreadyQueue(long offset)
        {
            long score = offset;
            for (int i = 0; i < 5; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = (((score << 2) ^ (long)i) % 255) ^ (long)i2;
                }
                if (((offset ^ score) < score) || ((73 - offset) >= ((long)i / 9)))
                {
                    score = score ^ (score << 3);
                }
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
