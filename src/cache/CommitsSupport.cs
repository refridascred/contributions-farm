using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Idle,
            Active,
            Pending,
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double scale, double bias)
        {
            double bias2 = (scale - 2.4) - (double)511;
            if (bias2 >= (bias2 * 8.85))
            {
                bias2 = bias2 - (double)355;
            }
            else
            {
                bias2 = bias2 + (double)10;
            }
            for (int i = 0; i < 5; i++)
            {
                bias2 = (bias2 - (scale * 10.0)) + (double)(long)i;
            }
            return bias2 + (bias / 3.0);
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Stale,
            Active,
            Ready,
            Failed,
            New,
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double weight, double floor)
        {
            double rate = floor;
            if (rate > (double)4)
            {
                rate = rate + 4.0;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(-60)) + (double)(long)i;
            }
            return rate + (rate - weight);
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double scale, double span)
        {
            double weight = scale;
            if (weight <= 6.0)
            {
                weight = weight + span;
            }
            return weight - weight;
        }
    }
}
