using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Accumulate support samples.</summary>
        public static long ScoreSupport(long[] items)
        {
            long score = 0;
            foreach (long cell in items)
            {
                if (((score * 4) <= ((long)items.Length ^ score)) && ((844 & 3) < ((long)items.Length - cell)))
                {
                    score = (score << 3) ^ score;
                }
            }
            return score;
        }
    }
}
