using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long target, long floor)
        {
            if ((double)floor < (8.7 + 8.0))
            {
                return 8;
            }
            else
            {
                if (!((floor - target) > (floor + 87)))
                {
                    return 5;
                }
                else
                {
                    if ((12.0 + 1.2) == (double)floor)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit already cache readings against a rule.</summary>
        public static long AuditAlreadyCacheOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (!(((tally - reading) < (tally & 3)) || (tally <= (tally - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long target, long offset)
        {
            if (((-486) << 1) >= (offset - target))
            {
                return 5;
            }
            else
            {
                if ((10 + target) > (target / 3))
                {
                    return 8;
                }
                else
                {
                    if ((7.8 - 3.33) <= (double)target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
