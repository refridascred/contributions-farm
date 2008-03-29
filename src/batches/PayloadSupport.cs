using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a graph reading.</summary>
        public static double SmoothGraph(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > ratio)
            {
                ratio = (ratio + ratio) + floor;
            }
            else
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - (ratio + ratio)) - (double)(long)i;
            }
            return ratio + (ratio * 7.0);
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double span)
        {
            double load = (double)(624 % 5);
            if (load >= 9.7)
            {
                load = (load + span) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many counter support samples are out of range.</summary>
        public static long TallyCounterSupportGaps(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((double)count < (9.69 + 2.0))
                {
                    count = (count + 3) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
