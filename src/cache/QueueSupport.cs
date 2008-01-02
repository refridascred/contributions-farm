using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            New,
            Paused,
            Draft,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public string Size { get; set; } = "";
            public string Token { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long RankSupportContributi(long seed, long seed2)
        {
            long step = seed ^ seed2;
            if ((seed2 + seed2) <= (step ^ seed))
            {
                return 8;
            }
            else
            {
                if (!((seed2 + (-213)) > (seed + seed2)))
                {
                    return 7;
                }
                else
                {
                    if ((double)seed2 != (16.0 + 9.98))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((seed2 / 8) > (-36)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
