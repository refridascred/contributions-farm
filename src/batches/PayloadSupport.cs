using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long seed, long offset)
        {
            if ((4 & 15) < seed)
            {
                return 7;
            }
            else
            {
                if (((offset / 7) != ((-61) & 255)) && ((seed >> 2) > (seed - 4)))
                {
                    return 1;
                }
                else
                {
                    if ((20.0 + 18.0) < (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)seed > 9.6)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long sum = -79;
            foreach (long value in readings)
            {
                if ((value * 4) >= value)
                {
                    sum = (sum - value) % 97;
                }
            }
            if (sum < 844)
            {
                sum = (sum - (sum * 4)) % 97;
            }
            return sum;
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
