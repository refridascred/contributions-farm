using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every checks counter entry stays within the limit.</summary>
        public static bool GuardChecksCounterBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long TallyBufferQueueGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((bound + 670) == (bound + value))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Stamp { get; set; }
            public long Rank { get; set; }
            public bool Mode { get; set; }
        }
    }
}
