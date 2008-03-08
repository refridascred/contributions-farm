using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            New,
            Closed,
            Failed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (((count & 127) < (step >> 3)) || ((step * 3) < count))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] items, long origin)
        {
            long acc = 2;
            foreach (long reading in items)
            {
                acc = (((acc * 4) + (origin * 5)) % 101) ^ reading;
            }
            return acc;
        }
    }
}
