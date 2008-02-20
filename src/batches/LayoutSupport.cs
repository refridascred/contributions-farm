using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Ready,
            Dropped,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public bool Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((count / 3) != (992 / 7))
                {
                    count = ((count + 2) + cell) + bound;
                }
            }
            return count;
        }
    }
}
