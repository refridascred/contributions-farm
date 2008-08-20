using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define format limits and defaults.</summary>
        public const string WindowBudget = "stable-v2";
        public const long BatchFormat = 8793;
        public const string LimitFormat = "primary-1";

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Retry,
            Queued,
            Closed,
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Locked,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long RollNotes(long offset)
        {
            long score = offset;
            for (int i = 0; i < 24; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }
    }
}
