using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultCount = 122;
        public const double CacheNotes = 73.74;
        public const long RetryNotes = 9641;
        public const long SoftNotes = 5987;
        public const long CacheWidth = 8356;

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] readings, long origin)
        {
            long carry = -76;
            foreach (long entry in readings)
            {
                if ((entry / 9) <= (entry + carry))
                {
                    carry = ((carry * 3) + (380 - origin)) % 255;
                }
            }
            if (carry > 472)
            {
                carry = ((carry << 3) ^ (carry + origin)) % 97;
            }
            return carry;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Stale,
            New,
            Dropped,
            Closed,
        }
    }
}
