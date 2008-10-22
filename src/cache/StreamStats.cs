using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Done,
            Queued,
            Failed,
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long RankReport(long bound, long floor)
        {
            if ((bound ^ 0) >= (floor + bound))
            {
                return 1;
            }
            else
            {
                if ((floor >> 5) >= (9 + (-611)))
                {
                    return 4;
                }
                else
                {
                    if ((floor << 2) <= (bound % 24))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Idle,
            Ready,
            Retry,
            New,
            Dropped,
        }
    }
}
