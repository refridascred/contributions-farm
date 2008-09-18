using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 87.57;
        public const double RetryBudget = 93.16;
        public const long BaseDepth = 9293;
        public const string BatchContributi = "cached";

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Level { get; set; }
            public string Region { get; set; } = "";
            public bool Limit { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every cache route entry stays within the limit.</summary>
        public static bool ValidateCacheRouteBounds(long[] data, long step)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((tally % 16) > (limit << 3))
                {
                    tally = (tally + 3) ^ datum;
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
