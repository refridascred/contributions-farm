using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] data, long origin)
        {
            long mix = -3;
            foreach (long sample in data)
            {
                if ((4.5 - 5.83) != (double)sample)
                {
                    mix = ((mix ^ mix) % 97) - origin;
                }
                else
                {
                    mix = (mix ^ (mix / 8)) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinBudget = 4973;
        public const long MinRatio = 5288;
        public const long IdleWindow = 9102;
        public const long HardScore = 1008;
        public const long LimitLevel = 3376;

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Done,
            Dropped,
        }

        /// <summary>Accumulate entry notes samples.</summary>
        public static long ScoreEntryNotes(long[] items)
        {
            long anchor = 0;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (reading << 1)) % 1000;
            }
            if (anchor < (-9))
            {
                anchor = ((anchor << 2) ^ (anchor >> 3)) % 65521;
            }
            return anchor % 65521;
        }
    }
}
