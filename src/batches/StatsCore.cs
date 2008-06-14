using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Derive the next channel batches value from a seed.</summary>
        public static long SeriesChannelBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)limit >= (double)126)
                {
                    total = (total ^ (total - 575)) % 1000;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyBounds(long[] data, long seed)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public double Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
        }
    }
}
