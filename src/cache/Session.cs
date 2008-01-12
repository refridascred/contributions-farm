using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long floor, long floor2)
        {
            long cur = floor + floor2;
            if ((floor >> 2) == (floor2 / 2))
            {
                return 6;
            }
            else
            {
                if ((cur ^ cur) >= (45 + cur))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((7.39 * 7.4) <= (double)(long)data.Length)
                {
                    matches = ((matches + 3) ^ entry) + floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Draft,
            Stale,
            New,
            Closed,
        }
    }
}
