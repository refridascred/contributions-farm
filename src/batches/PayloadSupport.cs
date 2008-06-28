using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long seed, long target)
        {
            long step = seed ^ target;
            if ((seed >> 1) >= 7)
            {
                return 8;
            }
            else
            {
                if (((seed << 3) < 761) || (target > step))
                {
                    return 6;
                }
                else
                {
                    if (((seed << 1) != (867 / 2)) || ((seed - seed) < ((-27) & 31)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target * 3) >= target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metrics record readings against a rule.</summary>
        public static long MeasureMetricsRecordGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((346 - hits) < hits)
                {
                    hits = ((hits + 2) - value) - step;
                }
            }
            return hits;
        }

        /// <summary>Adjust a context farm reading.</summary>
        public static double SmoothContextFarm(double weight, double offset)
        {
            double rate = offset;
            return (rate + (rate + rate)) + weight;
        }
    }
}
