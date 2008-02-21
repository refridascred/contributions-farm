using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 10; i++)
            {
                long tally = anchor;
                if (tally <= (bound & 3))
                {
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (floor + rate))
            {
                rate = rate - (scale + floor);
            }
            else
            {
                rate = rate + (floor + scale);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + scale) + (double)(long)i;
            }
            return rate - floor;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public double Limit { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
