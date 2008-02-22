using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] levels, long offset)
        {
            long score = 715;
            foreach (long value in levels)
            {
                if ((offset + score) == (4 % 10))
                {
                    score = score + offset;
                }
                else
                {
                    score = (score * 2) + (value >> 4);
                }
            }
            return score;
        }

        /// <summary>Find the first commits metric entry that matches the target.</summary>
        public static long LocateCommitsMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Ready,
            Active,
            Synced,
            Idle,
        }
    }
}
