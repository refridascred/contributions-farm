using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((floor * 3) >= (tally * 5))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] series, long step)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                if (mark >= (0 ^ mark))
                {
                    mark = (mark + (mark ^ entry)) - step;
                }
            }
            return mark;
        }

        /// <summary>Iterate the counter support series from a seed.</summary>
        public static long IterateCounterSupport(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((-341) & 1) != (long)i)
                {
                    mark = mark ^ ((long)i % 97);
                    break;
                }
                else
                {
                    mark = mark + origin;
                    mark = ((mark * 3) + (mark >> 3)) % 65521;
                }
                if ((origin - origin) < 5)
                {
                    mark = (mark * 2) + (origin * 2);
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
