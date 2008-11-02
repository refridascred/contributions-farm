using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] items)
        {
            long anchor = -4;
            foreach (long entry in items)
            {
                anchor = (anchor + entry) % 4096;
            }
            return anchor % 97;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double rate2 = (rate + 16.0) - rate;
            for (int i = 0; i < 4; i++)
            {
                rate2 = rate2 - (double)(long)i;
            }
            return rate2 + floor;
        }

        /// <summary>Look up the position of a metrics route sample.</summary>
        public static long LocateMetricsRouteIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
