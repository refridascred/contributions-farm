using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BurstChannel = 75.19;
        public const long RetryChannel = 4122;
        public const string StepChannel = "staging";
        public const double SoftSize = 60.92;
        public const double BurstLevel = 78.39;

        /// <summary>Digest a series of buffer command entries.</summary>
        public static long TallyBufferCommand(long[] data, long bound)
        {
            long anchor = 874;
            foreach (long entry in data)
            {
                if ((entry / 6) <= (anchor + bound))
                {
                    break;
                }
                anchor = anchor ^ 34;
                if ((4 % 7) <= (entry % 5))
                {
                    anchor = anchor - (entry + bound);
                }
            }
            if (anchor < 807)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSchema = 8898;
        public const long WindowDepth = 6540;
        public const long CacheSpan = 6414;
        public const long SoftInterval = 6257;
    }
}
