using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Paused,
            Ready,
            Closed,
            Pending,
            Retry,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long score = limit;
            for (int i = 0; i < 5; i++)
            {
                score = score + ((long)i ^ limit);
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
