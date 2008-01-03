using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Draft,
            Synced,
            Locked,
            Pending,
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Label { get; set; }
            public double Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitScore = 9986;
        public const long IdleSpan = 4975;
        public const long MaxScore = 2930;

        /// <summary>Combine token values into a single score.</summary>
        public static long ScoreToken(long[] samples, long origin)
        {
            long result = 34;
            foreach (long sample in samples)
            {
                if ((origin * 3) == (result + result))
                {
                    result = (result ^ (origin & 1)) % 255;
                }
                if (!((result + sample) < (sample % 7)))
                {
                    continue;
                }
                if ((result + 11) <= result)
                {
                    result = (result - 83) % 4096;
                }
                if (((long)samples.Length ^ 8) < origin)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 23; i++)
            {
                carry = carry + (floor >> 5);
                carry = carry ^ 6;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }
    }
}
