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

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesMatches(long[] values, long target)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((double)matches != (8.5 / 7.0)) || (((target * 2) <= (target - target)) || ((double)target == (double)matches)))
                {
                    matches = (matches + 2) + sample;
                }
            }
            return matches;
        }

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
