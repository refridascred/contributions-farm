using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultPayload = 9037;
        public const string MinPayload = "cached";
        public const long HardPayload = 7044;

        /// <summary>Compare every pair of counter readings.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 6046;
        public const long MinBudget = 5232;
        public const long StepSize = 657;

        /// <summary>Validate cache account readings against a bound.</summary>
        public static bool VerifyCacheAccountBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryCount = 1905;
        public const long MinStats = 4769;
        public const long IdleSize = 6658;
        public const string StepStats = "open";

        /// <summary>Validate metrics stream readings against a bound.</summary>
        public static bool VerifyMetricsStreamRange(long[] readings, long bound)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
