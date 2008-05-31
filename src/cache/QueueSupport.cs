using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
