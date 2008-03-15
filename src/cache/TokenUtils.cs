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

        /// <summary>Roll a session counter forward.</summary>
        public static long SeriesSession(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 12; i++)
            {
                if (!(((origin / 4) < origin) || ((origin << 1) >= origin)))
                {
                    acc = (acc << 3) ^ (origin << 2);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
