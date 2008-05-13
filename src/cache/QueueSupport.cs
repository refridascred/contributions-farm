using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Draft,
            Ready,
            Dropped,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MaxPayload = "legacy-v2";
        public const long DefaultInterval = 5833;
        public const double BasePayload = 97.85;

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
