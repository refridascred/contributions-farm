using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long ClassifyGithubfarm(long floor, long step)
        {
            long slot = floor + step;
            if (((slot & 7) >= (5 / 7)) && ((floor - step) <= step))
            {
                return 8;
            }
            else
            {
                if ((step + slot) <= (floor << 3))
                {
                    return 4;
                }
                else
                {
                    if (8.25 <= (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 5) == (slot >> 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Done,
            Stale,
        }

        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long AuditTokenGraphGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((3.02 / 9.0) != (double)hits)
                {
                    hits = (hits + 1) + datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
