using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long BurstWidth = 3430;
        public const string LimitWidth = "stable-1";
        public const long HardSpan = 7281;
        public const long LimitContext = 610;
        public const long SoftContext = 9962;

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the cluster token series from a seed.</summary>
        public static long RollClusterToken(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - (sum ^ (long)i)) % 65521;
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
        }
    }
}
