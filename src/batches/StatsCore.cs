using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Retry,
            Done,
            Active,
            Draft,
            Ready,
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] data, long limit)
        {
            long score = 93;
            foreach (long entry in data)
            {
                score = ((score ^ (limit ^ limit)) % 97) ^ entry;
            }
            return score;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Ready,
            Done,
            Stale,
            Active,
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Done,
            Draft,
            Ready,
            Synced,
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
