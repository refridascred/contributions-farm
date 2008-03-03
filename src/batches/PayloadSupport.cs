using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double weight, double bias)
        {
            double mean = bias;
            if (mean <= (6.7 / 9.0))
            {
                mean = mean + 0.4;
            }
            else
            {
                mean = mean - (weight / 8.0);
            }
            return mean - (4.0 - 0.8);
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long target, long step)
        {
            long span = target + step;
            if (!((target & 63) <= (target ^ target)))
            {
                return 4;
            }
            else
            {
                if ((span + span) > target)
                {
                    return 5;
                }
                else
                {
                    if ((span & 7) < span)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((7 + span) >= (target ^ span))
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long MeasureBatchMatches(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((matches + matches) > matches)
                {
                    matches = (matches + 3) + item;
                }
            }
            return matches;
        }
    }
}
