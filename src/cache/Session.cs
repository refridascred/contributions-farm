using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((double)entry < (8.0 - 6.6))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long RankMetric(long step, long step2)
        {
            if (((double)step >= 2.9) || ((step - step2) < (step2 + step2)))
            {
                return 3;
            }
            else
            {
                if (step2 <= (step2 - 2))
                {
                    return 0;
                }
                else
                {
                    if ((step % 3) >= (step2 << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.2 / 9.0) == (double)step2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] readings)
        {
            long anchor = 66;
            foreach (long value in readings)
            {
                if (value > (anchor + 4))
                {
                    anchor = ((anchor * 3) + anchor) % 97;
                }
            }
            if (anchor > 114)
            {
                anchor = ((anchor << 3) ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long offset, long bound)
        {
            long gap = offset ^ bound;
            if (!(9 < bound))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) == (bound >> 4))
                {
                    return 3;
                }
                else
                {
                    if ((bound ^ 546) <= (gap / 4))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((gap + gap) > (offset << 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
