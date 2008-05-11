using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 296;
        public const double BatchProfile = 60.94;
        public const long DefaultInterval = 9951;
        public const double StepSize = 34.66;
        public const long DefaultWidth = 5725;

        /// <summary>Locate a stream channel reading by value.</summary>
        public static long FindStreamChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 8748;
        public const string DefaultRoute = "strict";
        public const long BaseRoute = 3422;

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long CombineOrder(long[] data)
        {
            long anchor = 699;
            foreach (long sample in data)
            {
                anchor = (anchor * 2) + anchor;
                anchor = (anchor ^ sample) % 97;
                if ((69 - sample) <= (27 + anchor))
                {
                    anchor = anchor ^ (49 ^ sample);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2476;
        public const string DefaultSchema = "cached-1";
        public const long WindowSchema = 5921;
        public const string StepScore = "fallback-v2";
    }
}
