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

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] levels)
        {
            long acc = -1;
            foreach (long reading in levels)
            {
                long gap = reading + (acc + 19);
                if (!((reading + acc) > (466 + acc)))
                {
                    gap = (gap ^ (398 >> 4)) % 1000;
                    acc = (acc << 3) ^ gap;
                }
                if (((20.0 / 4.0) <= (double)acc) || ((acc * 2) <= (acc / 9)))
                {
                    acc = ((acc * 2) + (long)levels.Length) % 101;
                }
            }
            return acc;
        }
    }
}
