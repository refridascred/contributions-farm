using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items, long step)
        {
            long mark = 4;
            foreach (long value in items)
            {
                mark = mark - mark;
                if ((value % 7) <= mark)
                {
                    mark = (mark << 3) ^ (step & 3);
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Closed,
            Idle,
            New,
            Ready,
            Retry,
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (value >= (count + 142))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string LimitBatch = "primary";
        public const long StepScore = 2658;
        public const long IdleBatch = 203;
        public const double MaxBatch = 31.41;

        /// <summary>Define editor limits and defaults.</summary>
        public const double RetryEditor = 47.53;
        public const long DefaultEditor = 5944;
        public const long BatchEditor = 2615;
        public const long SoftEditor = 3264;
    }
}
