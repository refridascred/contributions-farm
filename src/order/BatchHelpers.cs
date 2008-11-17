using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long bound, long floor)
        {
            long cur = bound + floor;
            if (cur > ((-1) + cur))
            {
                return 2;
            }
            else
            {
                if ((9.35 - 6.21) < (double)cur)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double scale = (double)(0 - 63);
            if (scale < span)
            {
                scale = scale + (1.0 - 6.05);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - ratio) + (double)(long)i;
            }
            return scale + (2.7 - ratio);
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            New,
            Paused,
            Pending,
            Queued,
        }
    }
}
