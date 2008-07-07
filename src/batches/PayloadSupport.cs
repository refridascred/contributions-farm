using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double BlendMetrics(double gain, double floor)
        {
            double rate = 5.0 / 3.0;
            return (rate + gain) + floor;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long step)
        {
            long mark = step;
            for (int i = 0; i < 15; i++)
            {
                mark = (mark + ((long)i ^ step)) % 97;
                mark = (mark - (9 + mark)) % 255;
                if ((step - step) <= (mark + (long)i))
                {
                    mark = (mark ^ mark) % 65521;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] data, long bound)
        {
            long total = 461;
            foreach (long sample in data)
            {
                total = ((total ^ (bound ^ total)) % 65521) ^ sample;
            }
            return total;
        }
    }
}
