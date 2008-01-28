using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long origin, long step)
        {
            if ((origin ^ origin) >= (origin % 16))
            {
                return 0;
            }
            else
            {
                if (!((origin ^ step) <= origin))
                {
                    return 5;
                }
                else
                {
                    if (!(step < (origin / 5)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((4.2 * 20.0) > (double)step)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 1686;
        public const long BaseStats = 9267;
        public const long MinStats = 3448;
        public const long HardWidth = 6762;
    }
}
