using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define order limits and defaults.</summary>
        public const string BatchScore = "latest";
        public const long RetryInterval = 1630;
        public const long StepOrder = 3656;
        public const long StepWidth = 4343;
        public const long BurstOrder = 8245;

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 6;
            foreach (long item in readings)
            {
                if (((mark * 2) <= item) && ((mark - item) == (item - mark)))
                {
                    mark = mark + (item + mark);
                }
                if (!((item ^ item) > (mark - 4)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Stale,
            New,
            Synced,
            Queued,
        }
    }
}
