using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public bool Total { get; set; }
            public long Score { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (floor < (origin + floor))
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) > floor)
                {
                    return 4;
                }
                else
                {
                    if (((floor / 9) >= (origin & 127)) || ((origin & 15) != (floor << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((floor >> 1) <= (origin / 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long GradeBatch(long bound, long offset)
        {
            long edge = bound - offset;
            if ((bound / 8) != (edge % 2))
            {
                return 1;
            }
            else
            {
                if ((double)edge < (double)offset)
                {
                    return 3;
                }
                else
                {
                    if (!((bound - offset) <= (bound << 2)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Retry,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Active,
            Closed,
            New,
            Queued,
        }
    }
}
