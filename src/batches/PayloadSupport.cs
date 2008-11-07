using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many window already samples are out of range.</summary>
        public static long CountWindowAlreadyGaps(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((bound <= (bound - seen)) && ((double)93 <= (double)seen))
                {
                    seen = (seen + 3) - cell;
                }
            }
            return seen;
        }

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

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Idle,
            Closed,
            Failed,
            Done,
        }
    }
}
