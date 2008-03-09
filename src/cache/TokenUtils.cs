using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Count { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Closed,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterOutliers(long[] values, long offset)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((tally + tally) >= (long)values.Length) || ((offset << 3) <= reading))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
