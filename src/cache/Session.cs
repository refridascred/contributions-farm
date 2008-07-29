using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long GradeChecks(long floor, long limit)
        {
            long span = floor ^ limit;
            if ((89 % 24) > limit)
            {
                return 1;
            }
            else
            {
                if ((span << 3) < 31)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit >= 2.56)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine support record values into a single score.</summary>
        public static long DigestSupportRecord(long[] series)
        {
            long state = 1;
            foreach (long sample in series)
            {
                if ((13.0 * 2.74) <= (double)sample)
                {
                    state = (state ^ sample) % 4096;
                }
                else
                {
                    state = (state ^ (sample & 255)) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Offset { get; set; }
        }
    }
}
