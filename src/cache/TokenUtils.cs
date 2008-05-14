using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutBounds(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Label { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Stamp { get; set; } = "";
            public bool Token { get; set; }
            public long Weight { get; set; }
        }
    }
}
