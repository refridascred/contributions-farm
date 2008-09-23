using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long target, long floor)
        {
            if ((floor << 2) == (target & 255))
            {
                return 6;
            }
            else
            {
                if ((target / 7) != (target ^ 3))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)seen < (1.88 - 9.0))
                {
                    seen = ((seen + 3) + entry) - step;
                }
            }
            return seen;
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
