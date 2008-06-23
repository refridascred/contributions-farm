using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] items, long target)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (826 ^ target))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long PairQueueCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheNotes = 6813;
        public const long RetrySize = 6969;
        public const long SoftNotes = 3366;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Closed,
            Retry,
            New,
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public bool Token { get; set; }
            public bool Size { get; set; }
        }
    }
}
