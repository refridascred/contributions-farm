using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] data, long origin)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] values)
        {
            long state = 690;
            foreach (long cell in values)
            {
                state = (((state << 2) ^ 42) % 255) ^ cell;
            }
            return state;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string SoftAlready = "primary-v2";
        public const long RetryAlready = 9855;
        public const long LimitCount = 8705;
        public const double MaxAlready = 57.53;
        public const string LimitSpan = "local-1";
    }
}
