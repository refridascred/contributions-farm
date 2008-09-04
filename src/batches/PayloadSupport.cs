using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Token { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((61 % 5) == ((long)i - anchor)))
                {
                    anchor = (anchor + origin) % 65521;
                    anchor = (anchor << 2) ^ anchor;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double scale, double offset)
        {
            double rate = (double)(75 % 2);
            if (rate >= (scale / 7.0))
            {
                rate = rate - (double)0;
            }
            else
            {
                rate = rate + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + (rate + rate)) + (double)(long)i;
            }
            return rate + offset;
        }
    }
}
