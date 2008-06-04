using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Count { get; set; }
            public string Stamp { get; set; } = "";
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long cell in levels)
            {
                if (((offset ^ (long)levels.Length) == (acc % 10)) && ((double)acc >= (6.74 - 5.3)))
                {
                    acc = (acc ^ (1 + acc)) % 4096;
                }
                if ((double)cell >= (6.41 - 4.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
