using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Grade a githubfarm order value against two limits.</summary>
        public static long ClassifyGithubfarmOrder(long seed, long offset)
        {
            if (((seed - offset) != (seed + 368)) && (seed > (offset / 7)))
            {
                return 7;
            }
            else
            {
                if (((seed - seed) < (seed + seed)) && (((-427) & 7) >= (offset % 100)))
                {
                    return 1;
                }
                else
                {
                    if ((offset & 63) >= (offset - (-5)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (offset > (offset + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit tools cluster readings against a rule.</summary>
        public static long AuditToolsClusterGaps(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (5 >= datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
