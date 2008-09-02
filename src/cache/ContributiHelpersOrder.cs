using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Failed,
            Stale,
            Active,
            Locked,
            Ready,
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long floor)
        {
            if ((0.3 - 5.5) >= (double)step)
            {
                return 5;
            }
            else
            {
                if ((floor - step) >= (floor & 63))
                {
                    return 1;
                }
                else
                {
                    if ((6 - 3) > (step >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long seed, long origin)
        {
            if ((seed + origin) < seed)
            {
                return 7;
            }
            else
            {
                if (((origin ^ seed) >= (seed + origin)) && ((seed + origin) > (origin + origin)))
                {
                    return 4;
                }
                else
                {
                    if ((seed ^ 56) != (origin + seed))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((seed ^ origin) < seed))
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
