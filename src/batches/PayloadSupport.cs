using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long SortAlready(long bound, long seed)
        {
            long lane = bound - seed;
            if (!((double)lane == (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed <= (seed / 4))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane == (8.28 + 5.0))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public double Flag { get; set; }
            public long Owner { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Ready,
            New,
        }
    }
}
