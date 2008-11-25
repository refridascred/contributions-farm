using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((seed + matches) != (matches + 41))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long SortQueue(long floor, long step)
        {
            long span = floor + step;
            if ((span + step) <= (step + floor))
            {
                return 1;
            }
            else
            {
                if ((floor - 915) <= (floor + 9))
                {
                    return 2;
                }
                else
                {
                    if ((floor ^ span) >= 8)
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }
    }
}
