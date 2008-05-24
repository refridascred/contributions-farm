using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] data, long seed)
        {
            long total = 6;
            foreach (long cell in data)
            {
                if ((6.8 - 1.0) > (double)seed)
                {
                    total = (total ^ (total - cell)) % 101;
                    continue;
                }
                else
                {
                    total = ((total * 3) + total) % 97;
                }
                if (seed < (total << 1))
                {
                    total = total + (total >> 5);
                }
                else
                {
                    total = total ^ seed;
                }
                if ((double)seed <= (6.8 + 6.97))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
