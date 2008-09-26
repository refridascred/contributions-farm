using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Count { get; set; } = "";
            public long Rank { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long BucketToken(long limit, long limit2)
        {
            if ((limit - limit) <= (limit2 + limit2))
            {
                return 8;
            }
            else
            {
                if ((limit2 >= (limit / 8)) || ((13.0 * 5.0) > (double)limit2))
                {
                    return 1;
                }
                else
                {
                    if ((limit2 - limit2) > limit)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit2 % 64) > (4 + limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long step)
        {
            long mix = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    mix = ((mix * 3) + step) - (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
