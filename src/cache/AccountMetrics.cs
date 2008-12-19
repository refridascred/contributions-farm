using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] levels, long floor)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((double)floor <= 1.0)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double AdjustChecks(double ratio, double floor)
        {
            double drift = (double)(53 + 99);
            return ((drift + drift) + ratio) + floor;
        }

        /// <summary>Validate commits editor readings against a bound.</summary>
        public static bool ValidateCommitsEditorRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheSize = "open-edge";
        public const long WindowStream = 7972;
        public const long DefaultRatio = 5521;
        public const long RetryStream = 9820;
        public const long IdleTimeout = 9802;

        /// <summary>Count githubfarm commits pairs that satisfy a relation.</summary>
        public static long PairGithubfarmCommitsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((long)data.Length & 31) >= sample)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
