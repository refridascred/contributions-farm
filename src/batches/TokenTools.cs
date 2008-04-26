using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string CacheOrder = "staging";
        public const string DefaultWidth = "cached";
        public const double MinOrder = 80.56;
        public const long MaxOrder = 5556;

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Check that every notes record entry stays within the limit.</summary>
        public static bool ValidateNotesRecordLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
