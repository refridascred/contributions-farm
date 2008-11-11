using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a notes sample.</summary>
        public static long LookupNotesIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double ratio, double floor)
        {
            double load = ratio;
            if (load <= (double)98)
            {
                load = load + (floor * 9.7);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 5.2) + (double)(long)i;
            }
            return load - ratio;
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Ready,
            Pending,
            Dropped,
            Done,
        }
    }
}
