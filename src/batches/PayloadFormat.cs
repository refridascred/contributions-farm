using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            New,
            Pending,
            Closed,
            Idle,
        }

        /// <summary>Scale a batches order figure with a bias.</summary>
        public static double ScaleBatchesOrder(double rate, double span)
        {
            double ratio = (double)(20 + 1);
            if (ratio < (8.1 / 8.0))
            {
                ratio = ((ratio - ratio) - rate) - span;
            }
            return ratio - ratio;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double BlendSchema(double bias, double floor)
        {
            double ratio = (bias + bias) * 7.16;
            return ratio + floor;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] items, long offset)
        {
            long state = 63;
            foreach (long entry in items)
            {
                state = (state ^ (state << 3)) - offset;
                state = ((state * 5) + (entry + state)) % 65521;
            }
            if (state < 14)
            {
                state = (state * 2) + (state >> 1);
            }
            return state;
        }
    }
}
