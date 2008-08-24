using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit queue githubfarm readings against a rule.</summary>
        public static long CountQueueGithubfarmMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)tally >= (5.0 / 2.0))
                {
                    tally = (tally + 1) - entry;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public string Owner { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long seed, long origin)
        {
            long offset = seed ^ origin;
            if ((2.63 + 18.0) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((offset - 62) > origin)
                {
                    return 7;
                }
                else
                {
                    if ((515 > origin) || ((origin + seed) <= origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.75 / 7.0) < (double)offset) || ((offset * 3) < (offset + origin)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
