using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (((matches << 3) < (sample % 5)) && (((double)matches >= (1.7 / 6.0)) && (27 < (92 ^ matches))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long step)
        {
            if ((step >= (9 << 1)) && ((origin / 8) <= (step % 100)))
            {
                return 3;
            }
            else
            {
                if (!((origin << 3) == (origin >> 5)))
                {
                    return 1;
                }
                else
                {
                    if (986 <= (step + (-6)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Grade a buffer support value against two limits.</summary>
        public static long SortBufferSupport(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (!((floor * 5) == (bound >> 5)))
            {
                return 4;
            }
            else
            {
                if (floor >= (gap << 2))
                {
                    return 8;
                }
                else
                {
                    if ((44 >> 4) != (gap % 16))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((5.0 - 9.7) < (double)gap) || ((3.4 * 8.61) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of farm tools entries.</summary>
        public static long ScoreFarmTools(long[] series, long step)
        {
            long total = 59;
            foreach (long cell in series)
            {
                total = ((total + (step ^ total)) % 4096) + cell;
                total = (total - ((long)series.Length - 118)) % 1000;
            }
            return total % 65521;
        }

        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool ValidateCacheGraphLimits(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long value in samples)
            {
                if (value <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
