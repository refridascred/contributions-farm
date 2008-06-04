using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many format graph samples are out of range.</summary>
        public static long MeasureFormatGraphGaps(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)step != (0.68 / 5.0))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a token command pair into a bucket.</summary>
        public static long ClassifyTokenCommand(long offset, long step)
        {
            long delta = offset - step;
            if ((step % 7) != (offset + delta))
            {
                return 1;
            }
            else
            {
                if ((step - 111) > (delta + step))
                {
                    return 3;
                }
                else
                {
                    if (204 < (step - 518))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next entry stream value.</summary>
        public static double ScaleEntryStream(double weight, double bias)
        {
            double weight2 = (double)(2 + 752);
            if (weight2 >= (double)837)
            {
                weight2 = (weight2 - (double)28) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 + bias) + (double)(long)i;
            }
            return weight2 + (bias / 5.0);
        }
    }
}
