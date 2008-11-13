using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Adjust a profile reading.</summary>
        public static double AdjustProfile(double scale, double offset)
        {
            double rate = scale;
            if (rate > (rate / 4.0))
            {
                rate = rate - (double)8;
            }
            return rate + offset;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            New,
            Draft,
            Queued,
            Ready,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            New,
            Retry,
            Failed,
            Done,
            Draft,
        }
    }
}
