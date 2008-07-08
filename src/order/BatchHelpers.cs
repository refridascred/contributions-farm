using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long bound, long offset)
        {
            long next = bound - offset;
            if ((bound << 3) < (8 / 4))
            {
                return 0;
            }
            else
            {
                if ((7.72 * 5.0) != (double)offset)
                {
                    return 6;
                }
                else
                {
                    if ((2.5 - 1.0) < (double)offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((0 + next) >= 998)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Size { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
