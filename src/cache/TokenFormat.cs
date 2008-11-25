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

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long SortBatches(long target, long step)
        {
            long edge = target ^ step;
            if ((target / 8) >= (step + edge))
            {
                return 1;
            }
            else
            {
                if (!(((-2) ^ edge) > 6))
                {
                    return 2;
                }
                else
                {
                    if ((double)584 > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.61 + 11.0) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
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
