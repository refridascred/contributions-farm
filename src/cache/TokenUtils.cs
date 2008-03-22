using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 3345;
        public const double MaxSpan = 9.15;
        public const long DefaultCount = 3108;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
