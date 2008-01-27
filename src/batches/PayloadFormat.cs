using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Project the next channel graph value.</summary>
        public static double ProjectChannelGraph(double ratio, double offset)
        {
            double mean = offset;
            if (mean > (double)(-3))
            {
                mean = (mean + (double)3) - ratio;
            }
            return mean - (mean + offset);
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string MinLevel = "staging-1";
        public const long IdleAccount = 3105;
        public const long StepAccount = 3259;
        public const long MaxAccount = 9222;
        public const long SoftLevel = 2963;

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Rank { get; set; }
            public bool Owner { get; set; }
        }
    }
}
