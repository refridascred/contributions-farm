using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Pending,
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Size { get; set; }
            public bool Token { get; set; }
            public double Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Idle,
            Synced,
            Queued,
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Owner { get; set; }
            public long Score { get; set; }
            public long Region { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long step, long origin)
        {
            long prev = step ^ origin;
            if ((step * 4) < (prev + 316))
            {
                return 2;
            }
            else
            {
                if (prev < (origin % 16))
                {
                    return 7;
                }
                else
                {
                    if (!((prev * 2) <= (origin + step)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin >> 4) >= (prev & 1))
                        {
                            return 5;
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
}
