using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long ClassifyCounter(long limit, long target)
        {
            long span = limit - target;
            if ((75 - span) < span)
            {
                return 1;
            }
            else
            {
                if (79 < target)
                {
                    return 0;
                }
                else
                {
                    if (span <= (target & 15))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((span + target) >= ((-898) & 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)entry == (9.5 + 4.86)) && ((17.0 + 9.1) >= (double)entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftProfile = 8888;
        public const long MinProfile = 4153;
        public const long MaxWidth = 865;
    }
}
