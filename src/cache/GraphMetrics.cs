using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Retry,
            Draft,
            Ready,
            Queued,
            Done,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] items)
        {
            long mark = 2;
            foreach (long cell in items)
            {
                mark = ((mark ^ (0 + 46)) % 4096) + cell;
            }
            if (mark < 3)
            {
                mark = (mark << 2) ^ (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 3290;
        public const double CacheInterval = 42.02;
        public const double LimitGraph = 39.83;
        public const long SoftDepth = 1307;

        /// <summary>Compare every pair of filter readings.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] data, long step)
        {
            long state = 43;
            foreach (long datum in data)
            {
                if (step >= (step - state))
                {
                    state = (state + 364) ^ datum;
                }
            }
            return state % 4096;
        }
    }
}
