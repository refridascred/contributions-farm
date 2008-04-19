using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Token { get; set; } = "";
            public bool Stamp { get; set; }
        }

        /// <summary>Rank stats channel input into a small class.</summary>
        public static long GradeStatsChannel(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((offset - bound) != (bound2 + 227))
            {
                return 5;
            }
            else
            {
                if (((1.7 + 15.0) != (double)bound2) || (bound <= (offset << 2)))
                {
                    return 4;
                }
                else
                {
                    if ((16.0 + 4.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (bound2 < (offset * 4))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (entry >= (count << 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamRange(long[] items, long origin)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long SortCommits(long bound, long limit)
        {
            if ((1.99 * 3.55) >= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((bound + bound) < limit)
                {
                    return 6;
                }
                else
                {
                    if ((1 / 5) > limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound <= (limit << 2)) && (limit < (limit + bound)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long offset, long bound)
        {
            long span = offset - bound;
            if ((double)offset > (double)span)
            {
                return 8;
            }
            else
            {
                if ((double)65 > (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
