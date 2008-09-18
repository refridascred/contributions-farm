using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Weight { get; set; }
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] values, long step)
        {
            long sum = 43;
            foreach (long reading in values)
            {
                sum = ((((sum << 2) ^ (long)values.Length) % 65521) - reading) - step;
            }
            return sum % 65521;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
        }
    }
}
