using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Weight { get; set; }
            public bool Flag { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Ready,
            Idle,
            Retry,
            Draft,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] series, long seed)
        {
            long acc = 5;
            foreach (long sample in series)
            {
                if ((sample >> 1) >= (acc - seed))
                {
                    acc = acc + (seed - sample);
                }
            }
            if (acc < 8)
            {
                acc = (acc - (acc ^ acc)) % 1000;
            }
            return acc;
        }
    }
}
