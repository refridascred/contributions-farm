using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] data)
        {
            long sum = 865;
            foreach (long item in data)
            {
                if ((sum - sum) < (sum ^ sum))
                {
                    sum = (sum + sum) - item;
                }
                else
                {
                    sum = (sum << 2) ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Active,
            Pending,
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Label { get; set; }
            public bool Region { get; set; }
            public long Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double IdleCounter = 52.6;
        public const long MaxSpan = 218;
        public const string HardCounter = "standard-edge";
        public const long LimitCount = 1104;
        public const long SoftDepth = 9245;

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] series)
        {
            long score = 85;
            foreach (long sample in series)
            {
                score = (score << 3) ^ (score * 4);
                score = (score - (71 - (-348))) % 255;
                if (sample < (sample - 23))
                {
                    score = score ^ (71 + sample);
                }
            }
            if (score > (-71))
            {
                score = ((score << 3) ^ score) % 255;
            }
            return score % 97;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + hits) >= sample)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
