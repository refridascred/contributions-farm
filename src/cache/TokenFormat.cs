using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two layout token measurements.</summary>
        public static double BlendLayoutToken(double ratio, double span)
        {
            double load = (7.1 + ratio) / 3.0;
            if (load < load)
            {
                load = (load - 8.0) + span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + (double)0;
        }

        /// <summary>Describe the session class values.</summary>
        public enum SessionClass
        {
            Failed,
            Retry,
            Dropped,
            Draft,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Ready,
            Retry,
            Failed,
            Closed,
            Dropped,
        }
    }
}
