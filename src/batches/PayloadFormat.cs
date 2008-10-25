using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Active,
            Locked,
            Synced,
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long target, long bound)
        {
            long delta = target - bound;
            if (!((target % 12) >= (bound - target)))
            {
                return 4;
            }
            else
            {
                if ((6.0 * 7.82) != (double)delta)
                {
                    return 5;
                }
                else
                {
                    if (delta >= (target - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((delta * 2) <= delta)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((hits % 60) < hits)
                {
                    hits = ((hits + 1) + cell) + bound;
                }
            }
            return hits;
        }
    }
}
