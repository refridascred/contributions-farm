using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double offset)
        {
            double rate2 = (rate * 7.5) + (double)95;
            if (rate2 > (double)37)
            {
                rate2 = rate2 + offset;
            }
            else
            {
                rate2 = rate2 - rate2;
            }
            return rate2 + rate;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long seed, long step)
        {
            long gap = seed ^ step;
            if ((seed >> 2) > (83 - gap))
            {
                return 2;
            }
            else
            {
                if (!((7 & 7) >= (7 ^ gap)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)seed != (double)step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
