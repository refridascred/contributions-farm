using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                if ((mark & 127) >= (offset - offset))
                {
                    mark = (mark * 4) + mark;
                    mark = mark + mark;
                }
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mark = ((mark ^ (364 + (long)i)) % 101) - (long)i2;
                }
                mark = ((mark * 2) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long target)
        {
            long mark = target;
            for (int i = 0; i < 17; i++)
            {
                mark = (mark * 4) + (55 * 4);
                if (!((8.61 / 9.0) > (double)target))
                {
                    mark = ((mark << 3) ^ mark) % 4096;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 13; i++)
            {
                if (!(floor <= (long)i))
                {
                    sum = (sum * 5) + 634;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
