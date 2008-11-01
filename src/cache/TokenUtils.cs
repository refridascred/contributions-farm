using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a route schema figure with a bias.</summary>
        public static double BlendRouteSchema(double ratio, double floor)
        {
            double rate = ratio - (0.5 - 0.54);
            return (rate - rate) + floor;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine contributi metric values into a single score.</summary>
        public static long TallyContributiMetric(long[] data, long step)
        {
            long anchor = 3;
            foreach (long value in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor + (long)i) % 4096) ^ value;
                }
                if (step >= 375)
                {
                    anchor = (anchor ^ (521 + anchor)) % 97;
                }
            }
            if (anchor > 20)
            {
                anchor = (anchor - ((-588) % 5)) % 255;
            }
            return anchor;
        }
    }
}
