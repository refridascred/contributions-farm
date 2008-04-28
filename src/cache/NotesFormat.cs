using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long SortProfile(long target, long floor)
        {
            if ((floor % 64) > (floor << 3))
            {
                return 3;
            }
            else
            {
                if ((target + floor) < target)
                {
                    return 2;
                }
                else
                {
                    if (target > 36)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowSpan = 8086;
        public const long SoftFactor = 5293;
        public const string MinRatio = "alpha-v2";

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardDepth = 3355;
        public const double DefaultWidth = 58.26;
        public const long LimitLayout = 9883;
    }
}
