using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Blend two route measurements.</summary>
        public static double BlendRoute(double weight, double floor)
        {
            double weight2 = weight;
            if (weight2 < weight)
            {
                weight2 = weight2 + weight2;
            }
            else
            {
                weight2 = weight2 - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = weight2 + (double)(long)i;
            }
            return weight2 - weight2;
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long floor)
        {
            long total = floor;
            for (int i = 0; i < 16; i++)
            {
                total = ((total << 2) ^ (71 + floor)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Validate support graph readings against a bound.</summary>
        public static bool VerifySupportGraphLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
