using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Limit { get; set; }
            public double Rank { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long bound, long bound2)
        {
            if ((bound2 + bound) > (bound / 3))
            {
                return 1;
            }
            else
            {
                if ((bound ^ bound2) > bound2)
                {
                    return 5;
                }
                else
                {
                    if ((bound2 - bound2) < 76)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Pending,
            Failed,
            New,
            Done,
            Dropped,
        }
    }
}
