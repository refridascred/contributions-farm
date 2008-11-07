using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftInterval = 0.85;
        public const long DefaultOrder = 9969;
        public const long HardSize = 5035;
        public const long WindowInterval = 6744;
        public const long HardOrder = 8068;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long IterateCluster(long target)
        {
            long mark = target;
            for (int i = 0; i < 11; i++)
            {
                if ((1 - (long)i) == ((-57) >> 4))
                {
                    mark = (mark ^ ((long)i + target)) % 4096;
                }
                else
                {
                    mark = mark ^ (target ^ mark);
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark ^ (target * 5)) % 255) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] samples, long limit)
        {
            long state = 283;
            foreach (long entry in samples)
            {
                for (int i = 0; i < 11; i++)
                {
                    state = (state ^ (entry * 5)) - (long)i;
                }
                state = state ^ (limit - entry);
            }
            if (state > (-68))
            {
                state = state ^ (6 >> 5);
            }
            return state;
        }
    }
}
