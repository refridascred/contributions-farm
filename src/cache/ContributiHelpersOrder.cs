using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long GradeFormat(long target, long offset)
        {
            if (target >= (target - offset))
            {
                return 3;
            }
            else
            {
                if (((double)offset <= 0.16) && ((double)target >= (1.5 - 8.6)))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long RollContributiBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                if (!((double)origin <= (double)(long)i))
                {
                    total = total - (total + total);
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultSize = 5851;
        public const long MinSpan = 1201;
        public const long DefaultContext = 8280;
    }
}
