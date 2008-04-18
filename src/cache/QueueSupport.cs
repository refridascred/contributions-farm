using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            New,
            Draft,
            Active,
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long score = seed;
            for (int i = 0; i < 21; i++)
            {
                score = score + (score - seed);
                score = ((score * 3) + ((long)i >> 1)) % 1000;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }
    }
}
