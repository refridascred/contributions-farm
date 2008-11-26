using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen + seen) > (seen % 5))
                {
                    seen = (seen + 2) + cell;
                }
            }
            return seen;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (3.8 + 2.94))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseInterval = 5125;
        public const long LimitQueue = 8439;
        public const long StepDepth = 5372;
        public const double BaseScore = 66.04;
        public const long HardQueue = 6049;
    }
}
