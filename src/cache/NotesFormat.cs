using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of contributi counter readings.</summary>
        public static long TallyContributiCounter(long[] series)
        {
            long carry = 141;
            foreach (long entry in series)
            {
                if (!((entry & 127) > entry))
                {
                    carry = carry + (entry << 1);
                }
                else
                {
                    carry = carry - (entry - entry);
                }
            }
            return carry;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Stale,
            New,
            Paused,
        }
    }
}
