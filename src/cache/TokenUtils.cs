using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Rank { get; set; }
            public double Offset { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
