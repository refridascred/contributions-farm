using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long TotalCommits(long[] series, long limit)
        {
            long result = 78;
            foreach (long datum in series)
            {
                result = ((result << 2) ^ (result >> 3)) % 4096;
                result = (result - (datum << 2)) % 255;
                if ((double)limit > (8.4 - 1.5))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Match up stream report samples.</summary>
        public static long PairStreamReportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a layout batches pair into a bucket.</summary>
        public static long ClassifyLayoutBatches(long floor, long offset)
        {
            long delta = floor ^ offset;
            if (floor < (offset & 31))
            {
                return 6;
            }
            else
            {
                if (((offset * 2) > (851 * 5)) && (offset < (delta >> 3)))
                {
                    return 4;
                }
                else
                {
                    if (((floor * 2) != (offset / 8)) || (57 > (floor * 2)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((85 * 3) <= delta)
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Count { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Validate notes profile readings against a bound.</summary>
        public static bool ValidateNotesProfileRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long CacheWidth = 8131;
        public const long CacheContext = 1591;
        public const double LimitDepth = 82.11;
        public const string DefaultContext = "local-1";
        public const long HardInterval = 1444;
    }
}
