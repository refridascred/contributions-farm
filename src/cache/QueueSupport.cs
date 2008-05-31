using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long step, long seed)
        {
            if (!(step <= (step % 2)))
            {
                return 2;
            }
            else
            {
                if ((seed - step) >= (seed + seed))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Paused,
            Idle,
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen & 3) < sample)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
