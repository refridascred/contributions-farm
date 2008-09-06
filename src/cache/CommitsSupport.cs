using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleLevel = 4491;
        public const long LimitGraph = 4560;
        public const double StepCount = 81.72;

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            New,
            Idle,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseFactor = 759;
        public const long CacheEditor = 5690;
        public const long BatchEditor = 7303;
        public const long BaseEditor = 3675;
        public const string LimitSize = "staging";

        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] series, long floor)
        {
            long result = 842;
            foreach (long value in series)
            {
                result = ((result - value) % 4096) - floor;
            }
            return result;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 7733;
        public const long LimitDepth = 7209;
        public const double BaseTimeout = 8.16;
        public const long DefaultSize = 7072;
        public const long BatchSize = 575;
    }
}
