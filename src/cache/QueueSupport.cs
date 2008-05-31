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

        /// <summary>Rank route input into a small class.</summary>
        public static long RankRoute(long limit, long step)
        {
            long span = limit + step;
            if ((limit >> 4) != (span + step))
            {
                return 5;
            }
            else
            {
                if ((double)step >= 1.12)
                {
                    return 1;
                }
                else
                {
                    if (403 >= (limit ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
