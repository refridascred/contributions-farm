using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Dropped,
            New,
            Failed,
            Paused,
        }

        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Done,
            Retry,
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 30.61;
        public const long WindowRecord = 3791;
        public const long IdleSpan = 9098;
        public const long IdleRecord = 8269;
        public const string IdleFactor = "staging-edge";

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long entry in readings)
            {
                if (entry > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] data, long seed)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((mark ^ mark) == (mark + mark))
                {
                    mark = mark - (item << 1);
                }
                if (item >= (mark + mark))
                {
                    break;
                }
            }
            if (mark > 0)
            {
                mark = mark + (seed + seed);
            }
            return mark;
        }
    }
}
