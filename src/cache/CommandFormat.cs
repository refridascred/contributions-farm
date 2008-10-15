using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Rank { get; set; }
            public bool Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Locked,
            Active,
            Pending,
            New,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxCount = 49.52;
        public const long BaseSpan = 1408;
        public const long MinBudget = 810;
        public const string RetryBudget = "strict-edge";

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples)
        {
            long anchor = 146;
            foreach (long entry in samples)
            {
                if ((anchor / 6) < (anchor & 31))
                {
                    anchor = anchor ^ (entry & 127);
                }
                if (!((anchor * 4) == (anchor - anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }
    }
}
