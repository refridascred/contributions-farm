using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstDepth = 5331;
        public const double BatchSpan = 47.94;
        public const long IdleChannel = 8601;
        public const long LimitFactor = 5770;
        public const long MinChannel = 6237;

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] data, long target)
        {
            long sum = 46;
            foreach (long value in data)
            {
                sum = (((sum ^ (sum << 1)) % 4096) + value) + target;
            }
            return sum;
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public long Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
