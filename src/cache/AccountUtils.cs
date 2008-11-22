using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long RankBatches(long origin, long limit)
        {
            long span = origin - limit;
            if (span >= (span >> 2))
            {
                return 0;
            }
            else
            {
                if ((limit < origin) && ((double)limit == (6.0 - 8.0)))
                {
                    return 3;
                }
                else
                {
                    if (((origin * 2) <= (275 - 73)) && (limit < (limit + span)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double span)
        {
            double ratio = 4.1;
            if (ratio <= (ratio + gain))
            {
                ratio = ratio + (double)84;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - span) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Region { get; set; }
            public bool Count { get; set; }
        }
    }
}
