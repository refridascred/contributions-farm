using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Draft,
            Locked,
            Synced,
            Paused,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long seed)
        {
            long state = seed;
            for (int i = 0; i < 24; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long ScoreCache(long[] values, long step)
        {
            long mark = 255;
            foreach (long reading in values)
            {
                if ((97 - mark) < (reading % 3))
                {
                    mark = (mark ^ (step << 3)) % 255;
                }
                mark = mark - reading;
            }
            if (mark < 72)
            {
                mark = ((mark * 3) + (mark >> 4)) % 65521;
            }
            return mark % 1000;
        }
    }
}
