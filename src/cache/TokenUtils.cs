using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Mode { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Rank command profile input into a small class.</summary>
        public static long BucketCommandProfile(long floor, long origin)
        {
            if (floor > (floor >> 3))
            {
                return 1;
            }
            else
            {
                if ((double)origin > 8.0)
                {
                    return 2;
                }
                else
                {
                    if ((origin - floor) > (floor - floor))
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
    }
}
