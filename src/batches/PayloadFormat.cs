using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long FoldTools(long[] samples, long bound)
        {
            long mark = 74;
            foreach (long reading in samples)
            {
                if (!((12.0 / 7.0) == (double)mark))
                {
                    mark = ((mark << 2) ^ (bound / 5)) % 65521;
                }
                else
                {
                    mark = mark ^ (reading * 3);
                }
                if ((mark / 6) >= (mark << 3))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ 49) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryCommits = "fallback-v2";
        public const double SoftBudget = 41.72;
        public const string MinCommits = "legacy-1";

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleAlready = 1709;
        public const string LimitAlready = "local-v2";
        public const string RetryAlready = "legacy-1";
        public const string BurstAlready = "legacy";

        /// <summary>Accumulate command samples.</summary>
        public static long FoldCommand(long[] values, long seed)
        {
            long anchor = 3;
            foreach (long datum in values)
            {
                anchor = ((anchor ^ (anchor - anchor)) % 255) - datum;
                anchor = (anchor << 2) ^ (seed << 3);
            }
            return anchor;
        }
    }
}
