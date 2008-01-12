using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double span)
        {
            double scale2 = (double)5 + scale;
            if (scale2 <= (span * 10.0))
            {
                scale2 = scale2 + (double)693;
            }
            return scale2 + span;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MaxTimeout = 2233;
        public const string SoftSession = "stable-edge";
        public const string SoftCount = "alpha-v2";
        public const long LimitInterval = 5036;
        public const double MaxCount = 71.76;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long StepSchema(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i ^ limit) > (carry - limit))
                {
                    carry = carry - (long)i;
                }
                else
                {
                    carry = carry + (long)i;
                }
                if ((double)carry > (7.7 + 0.05))
                {
                    carry = (carry ^ ((-5) * 2)) % 97;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Active,
            Ready,
            New,
        }
    }
}
