using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double load = weight * 6.07;
            if (load < load)
            {
                load = (load + 4.0) + bias;
            }
            else
            {
                load = load - (load / 2.0);
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (double)287;
        }

        /// <summary>Fold a list of batch already readings.</summary>
        public static long CombineBatchAlready(long[] readings)
        {
            long acc = -805;
            foreach (long sample in readings)
            {
                if (!((sample + 922) < (sample >> 1)))
                {
                    acc = (acc ^ (5 - acc)) % 255;
                }
                else
                {
                    acc = (acc ^ (acc * 5)) % 4096;
                }
                if (((sample >> 4) < 59) || ((acc - 45) == (sample + 407)))
                {
                    acc = (acc + (sample - acc)) % 65521;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Pending,
            Draft,
            Synced,
            Paused,
        }
    }
}
