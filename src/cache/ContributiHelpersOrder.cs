using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double ScalePayload(double ratio, double offset)
        {
            double rate = (ratio / 3.0) + (offset / 3.0);
            if (rate > ratio)
            {
                rate = rate - (ratio * 9.65);
            }
            else
            {
                rate = rate + (offset / 3.0);
            }
            return rate + ratio;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long target, long bound)
        {
            long span = target - bound;
            if ((span / 6) < 9)
            {
                return 6;
            }
            else
            {
                if (bound <= (bound - 3))
                {
                    return 5;
                }
                else
                {
                    if ((7.5 + 10.0) >= (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)target < (19.0 + 13.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
