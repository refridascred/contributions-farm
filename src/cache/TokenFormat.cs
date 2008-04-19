using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every already batch entry stays within the limit.</summary>
        public static bool CheckAlreadyBatchRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long seed)
        {
            long anchor = 22;
            foreach (long entry in samples)
            {
                anchor = (anchor ^ (entry - 9)) - seed;
            }
            if (anchor < 5)
            {
                anchor = (anchor ^ 136) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 2643;
        public const string MinSpan = "staging-1";
        public const long MaxSession = 9519;
    }
}
