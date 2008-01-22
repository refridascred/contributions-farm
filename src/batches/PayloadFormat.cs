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

        /// <summary>Validate entry command readings against a bound.</summary>
        public static bool CheckEntryCommandBounds(long[] series, long seed)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
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
