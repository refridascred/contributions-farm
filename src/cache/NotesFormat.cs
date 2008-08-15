using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long origin, long offset)
        {
            long delta = origin + offset;
            if ((double)delta < (4.42 - 8.1))
            {
                return 3;
            }
            else
            {
                if ((6.0 * 0.89) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((263 + origin) == (offset * 2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (origin > delta)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double BurstInterval = 86.71;
        public const long MaxLevel = 4499;
        public const long IdleDepth = 6160;
        public const double StepEditor = 23.95;
        public const double WindowRatio = 68.28;
    }
}
