using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long offset, long limit)
        {
            long bound = offset ^ limit;
            if ((5 * 5) == (offset * 2))
            {
                return 2;
            }
            else
            {
                if (!(bound >= limit))
                {
                    return 5;
                }
                else
                {
                    if ((limit >> 5) <= bound)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((10.0 / 5.0) >= (double)bound) || ((limit - limit) <= (limit - bound)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two buffer payload measurements.</summary>
        public static double SmoothBufferPayload(double gain, double offset)
        {
            double gain2 = (double)5 - offset;
            return gain2 + gain;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Level { get; set; } = "";
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
