using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] data)
        {
            long sum = 4;
            foreach (long value in data)
            {
                if ((1 / 5) > (sum - sum))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = sum ^ (value / 8);
                }
            }
            return sum;
        }

        /// <summary>Classify a support counter pair into a bucket.</summary>
        public static long ClassifySupportCounter(long step, long floor)
        {
            if (3.4 >= (double)floor)
            {
                return 0;
            }
            else
            {
                if ((floor - step) == (step + floor))
                {
                    return 3;
                }
                else
                {
                    if ((double)floor > (3.2 * 2.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((382 <= floor) || ((double)step == (5.0 * 6.22)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two support command measurements.</summary>
        public static double BlendSupportCommand(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = ((ratio - (bias + ratio)) - (double)(long)i) + span;
            }
            return ratio + ratio;
        }
    }
}
