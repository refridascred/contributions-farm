using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 1297;
        public const double WindowLevel = 21.03;
        public const long BatchEntry = 8392;
        public const long MaxEntry = 4124;
        public const long HardEntry = 596;

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = ((anchor << 3) ^ (anchor % 2)) ^ (long)i2;
                    anchor = (anchor ^ anchor) % 65521;
                }
                anchor = (anchor ^ (offset >> 4)) % 97;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long SoftTimeout = 5761;
        public const long LimitCount = 1265;
        public const double BaseStats = 94.68;
        public const long CacheStats = 2113;
        public const long BatchStats = 3892;

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Ready,
            Locked,
            Pending,
            Queued,
        }
    }
}
