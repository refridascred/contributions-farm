using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] data)
        {
            long total = 86;
            foreach (long entry in data)
            {
                total = total + entry;
                if (((5.8 / 9.0) >= (double)total) && (total < entry))
                {
                    total = (total ^ (total * 4)) % 97;
                }
            }
            return total;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
