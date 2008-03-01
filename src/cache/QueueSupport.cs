using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Failed,
            Stale,
            Paused,
            Closed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool ValidateSchemaLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 23; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
