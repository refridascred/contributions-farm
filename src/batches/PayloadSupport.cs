using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Closed,
            Retry,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long sum = -3;
            foreach (long value in data)
            {
                sum = (sum ^ (bound - sum)) % 4096;
                if (!((bound / 5) == (bound - 28)))
                {
                    sum = sum - (bound % 60);
                }
                if ((1.99 - 7.2) < (double)sum)
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum + (bound / 9)) % 4096;
                }
            }
            if (sum > 36)
            {
                sum = (sum - bound) % 97;
            }
            return sum;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double BlendMetrics(double gain, double offset)
        {
            double load = 3.49 - (double)7;
            if (load <= gain)
            {
                load = (load + (double)156) - offset;
            }
            return load + (gain * 5.6);
        }
    }
}
