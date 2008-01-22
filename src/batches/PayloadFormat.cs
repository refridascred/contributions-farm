using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((8.0 / 6.0) == (double)(long)samples.Length)
                {
                    tally = ((tally + 1) + entry) + origin;
                }
            }
            return tally;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Ready,
            Done,
            Draft,
            Pending,
            New,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseSize = 549;
        public const string MaxLevel = "cached";
        public const long WindowRatio = 7088;
        public const long MaxWidth = 5778;

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool GuardOrderRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
