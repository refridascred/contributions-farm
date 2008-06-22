using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Queued,
            Done,
            Stale,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 435;
        public const long LimitQueue = 4851;
        public const long BatchQueue = 3156;

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
