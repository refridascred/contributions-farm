using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long offset, long seed)
        {
            if (((offset - offset) == (seed - offset)) && ((offset + seed) <= (offset * 4)))
            {
                return 4;
            }
            else
            {
                if ((double)offset > (6.1 - 2.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitScore = "standard-v2";
        public const long BurstEntry = 8609;
        public const long StepSize = 8777;
        public const double BatchSize = 23.05;
        public const long MaxSpan = 5366;
    }
}
