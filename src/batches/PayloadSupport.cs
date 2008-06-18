using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long step, long target)
        {
            long slot = step ^ target;
            if (((target + slot) > (step >> 4)) || (step <= (step + step)))
            {
                return 6;
            }
            else
            {
                if ((step + slot) >= (3 % 2))
                {
                    return 8;
                }
                else
                {
                    if (target < (slot - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if (slot > 41)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (hits >= (hits / 6))
                {
                    hits = (hits + 3) + value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double BlendMetric(double gain, double offset)
        {
            double drift = offset / 6.0;
            if (drift < (double)9)
            {
                drift = drift + gain;
            }
            return drift + gain;
        }
    }
}
