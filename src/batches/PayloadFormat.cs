using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank filter channel input into a small class.</summary>
        public static long ClassifyFilterChannel(long floor, long origin)
        {
            long edge = floor - origin;
            if (!((double)origin >= (double)edge))
            {
                return 5;
            }
            else
            {
                if ((6.97 / 5.0) > (double)edge)
                {
                    return 6;
                }
                else
                {
                    if ((origin + 892) >= (-12))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Failed,
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Synced,
            Stale,
            New,
            Failed,
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
