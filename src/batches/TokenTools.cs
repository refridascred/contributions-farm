using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long origin, long limit)
        {
            if (origin <= limit)
            {
                return 7;
            }
            else
            {
                if (!(origin >= 8))
                {
                    return 2;
                }
                else
                {
                    if (((30 - 2) < (origin - limit)) && ((double)origin <= 9.9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Paused,
            Ready,
            New,
            Queued,
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public long Level { get; set; }
            public long Limit { get; set; }
        }
    }
}
