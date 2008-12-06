using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (!((5 + offset) >= (limit % 100)))
            {
                return 0;
            }
            else
            {
                if ((offset2 - 354) <= (offset & 7))
                {
                    return 1;
                }
                else
                {
                    if ((offset + offset2) >= (offset >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double WindowCommits = 95.53;
        public const double LimitScore = 25.59;
        public const long LimitCount = 8355;
        public const string MinCommits = "stable";

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool GuardBatchBounds(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
