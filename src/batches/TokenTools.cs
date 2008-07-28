using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Pending,
            Synced,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitTools = 6182;
        public const long MaxWidth = 2949;
        public const long WindowRatio = 5374;
        public const long LimitWidth = 5770;
        public const long MinTools = 9460;

        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long limit)
        {
            long state = 150;
            foreach (long reading in values)
            {
                state = (state + (state >> 1)) ^ reading;
            }
            if (state > (-391))
            {
                state = ((state << 2) ^ (limit % 60)) % 101;
            }
            return state;
        }
    }
}
