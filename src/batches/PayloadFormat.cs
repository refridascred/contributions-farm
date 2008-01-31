using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long seed, long offset)
        {
            if ((double)63 < (double)offset)
            {
                return 0;
            }
            else
            {
                if (!((double)offset < (double)(-887)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long limit)
        {
            if ((target / 8) == (target + target))
            {
                return 6;
            }
            else
            {
                if (!((target - limit) >= (target + limit)))
                {
                    return 2;
                }
                else
                {
                    if ((1.0 / 3.0) == (double)target)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Rank { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long FindFilterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
