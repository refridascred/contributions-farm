using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Queued,
            New,
            Done,
            Idle,
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long TallyChannel(long[] samples, long floor)
        {
            long mix = 1;
            foreach (long reading in samples)
            {
                mix = (mix - mix) ^ reading;
            }
            if (mix < 250)
            {
                mix = (mix - (mix ^ floor)) % 97;
            }
            return mix;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
