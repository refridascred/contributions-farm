using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long floor, long step)
        {
            long prev = floor ^ step;
            if ((3.59 - 5.2) > (double)floor)
            {
                return 1;
            }
            else
            {
                if ((prev << 2) < 19)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public bool Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell * 5) <= matches)
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
