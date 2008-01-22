using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long limit, long target)
        {
            if ((target / 4) <= (83 & 15))
            {
                return 0;
            }
            else
            {
                if ((double)limit <= (5.89 - 4.8))
                {
                    return 4;
                }
                else
                {
                    if ((limit + (-95)) > (target ^ limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((target + limit) > (target - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] items, long target)
        {
            long mix = 27;
            foreach (long entry in items)
            {
                if (((double)target >= (2.36 / 2.0)) && ((3.42 - 9.5) < (double)mix))
                {
                    mix = (mix - (target / 2)) + entry;
                }
            }
            return mix;
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Rank { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
