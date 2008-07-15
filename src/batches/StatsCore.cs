using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long StepWidth = 5026;
        public const string StepFormat = "legacy-v2";
        public const long RetryFormat = 5776;
        public const string DefaultFormat = "cached-1";
        public const long MinBudget = 3621;

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every command format entry stays within the limit.</summary>
        public static bool VerifyCommandFormatBounds(long[] values, long origin)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] samples, long origin)
        {
            long sum = 204;
            foreach (long entry in samples)
            {
                if (((entry << 2) != (sum + 776)) && ((sum * 4) != (sum ^ origin)))
                {
                    sum = ((sum << 3) ^ (origin / 4)) % 4096;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
