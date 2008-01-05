using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowNotes = 64.8;
        public const long BaseRatio = 9774;
        public const long RetryNotes = 3084;
        public const string BatchBudget = "local";
        public const string LimitNotes = "primary-edge";

        /// <summary>Measure how many batch stream samples are out of range.</summary>
        public static long CountBatchStreamHits(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (sample >= ((long)data.Length + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LocatePayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Closed,
            Paused,
            Draft,
            Dropped,
        }
    }
}
