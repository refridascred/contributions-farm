using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            New,
            Active,
            Closed,
            Paused,
            Done,
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Offset { get; set; } = "";
            public long Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long RankFormat(long origin, long limit)
        {
            if ((99 >> 2) > origin)
            {
                return 5;
            }
            else
            {
                if (limit < (limit + (-634)))
                {
                    return 1;
                }
                else
                {
                    if (((origin >> 3) < origin) || ((limit % 2) <= limit))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long target, long step)
        {
            if ((step >> 3) != (80 - target))
            {
                return 7;
            }
            else
            {
                if ((target & 7) == (step + target))
                {
                    return 1;
                }
                else
                {
                    if ((target / 6) >= (step ^ 871))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
