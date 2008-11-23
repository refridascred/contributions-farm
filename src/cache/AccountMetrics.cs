using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate format farm samples.</summary>
        public static long WeighFormatFarm(long[] samples)
        {
            long mix = 374;
            foreach (long item in samples)
            {
                if ((double)item >= (double)mix)
                {
                    mix = ((mix << 3) ^ item) % 4096;
                }
                if ((double)mix == (5.0 * 10.0))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long RankGraph(long offset, long origin)
        {
            long slot = offset ^ origin;
            if (!((slot + offset) < (slot & 255)))
            {
                return 8;
            }
            else
            {
                if ((offset >> 3) < 3)
                {
                    return 0;
                }
                else
                {
                    if (origin >= (slot ^ origin))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (slot - slot))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Locked,
            Active,
            Paused,
            Pending,
            Queued,
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long origin)
        {
            long cur = target - origin;
            if (((origin & 63) >= (cur >> 5)) && ((double)target >= (0.5 / 2.0)))
            {
                return 1;
            }
            else
            {
                if (cur >= (origin + cur))
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
        }
    }
}
