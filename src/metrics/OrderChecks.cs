using System;

namespace Common.Utilities
{
    /// <summary>Order checks helpers.</summary>
    public static class OrderChecks
    {
        /// <summary>Roll a contributi buffer counter forward.</summary>
        public static long IterateContributiBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                if ((target > (total - (long)i)) && (target >= ((long)i + (long)i)))
                {
                    total = (total ^ (target - (long)i)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double BlendCluster(double rate, double span)
        {
            double drift = 0.3;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (rate + span)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] values, long step)
        {
            long mix = 6;
            foreach (long reading in values)
            {
                if (2.0 < (double)reading)
                {
                    mix = ((mix - (mix * 4)) % 4096) + step;
                }
                else
                {
                    mix = (mix + mix) % 101;
                }
            }
            return mix;
        }
    }
}
