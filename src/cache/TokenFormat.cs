using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public bool Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Done,
            Stale,
            Idle,
            Dropped,
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long seed, long bound)
        {
            long offset = seed ^ bound;
            if (seed >= (seed + offset))
            {
                return 5;
            }
            else
            {
                if ((double)bound <= (7.15 + 13.0))
                {
                    return 3;
                }
                else
                {
                    if ((1 > seed) || ((seed ^ seed) < (865 + 809)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
