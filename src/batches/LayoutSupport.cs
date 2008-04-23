using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i != (7.5 - 4.0))
                {
                    score = (score + (limit - score)) % 255;
                    break;
                }
                score = (score - score) % 4096;
                score = ((score * 2) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchLayout = 2090;
        public const string CacheSpan = "fallback-1";
        public const long MaxLayout = 1078;
        public const long CacheWidth = 348;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Idle,
            Dropped,
            New,
            Ready,
        }
    }
}
