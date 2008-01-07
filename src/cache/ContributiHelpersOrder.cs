using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Total { get; set; } = "";
            public bool Limit { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] series, long target)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long RankBatch(long limit, long seed)
        {
            long step = limit ^ seed;
            if ((0.59 / 6.0) < (double)step)
            {
                return 6;
            }
            else
            {
                if (step > (seed % 10))
                {
                    return 1;
                }
                else
                {
                    if ((step * 2) >= (limit * 5))
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
    }
}
