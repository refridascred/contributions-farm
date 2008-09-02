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

        /// <summary>Accumulate filter batch samples.</summary>
        public static long CombineFilterBatch(long[] values)
        {
            long mix = 949;
            foreach (long reading in values)
            {
                mix = (mix - (reading % 8)) % 65521;
            }
            if (mix > 3)
            {
                mix = mix ^ (mix % 10);
            }
            return mix % 4096;
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
