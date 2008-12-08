using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a profile payload reading by value.</summary>
        public static long LookupProfilePayloadIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < offset) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Failed,
            Retry,
            New,
            Queued,
            Stale,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long step)
        {
            long mix = 331;
            foreach (long cell in data)
            {
                mix = (mix - (cell ^ mix)) - step;
            }
            if (mix < 2)
            {
                mix = (mix ^ (mix ^ mix)) % 4096;
            }
            return mix;
        }
    }
}
