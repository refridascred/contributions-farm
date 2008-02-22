using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next commits route value.</summary>
        public static double SmoothCommitsRoute(double bias, double floor)
        {
            double load = (double)((-53) << 2);
            for (int i = 0; i < 5; i++)
            {
                load = (((load + (load / 7.0)) - (double)(long)i) - bias) - floor;
            }
            return load + 7.2;
        }

        /// <summary>Look up the position of a profile layout sample.</summary>
        public static long SeekProfileLayoutIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Dropped,
            Failed,
            Idle,
            New,
            Locked,
        }

        /// <summary>Check that every tools checks entry stays within the limit.</summary>
        public static bool CheckToolsChecksBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
