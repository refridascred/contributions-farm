using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Accumulate cache window samples.</summary>
        public static long FoldCacheWindow(long[] data)
        {
            long total = 14;
            foreach (long datum in data)
            {
                total = total + 57;
                for (int i = 0; i < 3; i++)
                {
                    total = (total - ((long)data.Length ^ (long)i)) % 1000;
                    total = (total - (total >> 3)) % 4096;
                }
                total = (total + (datum ^ 0)) % 1000;
            }
            return total;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double gain, double span)
        {
            double ratio = (double)(156 + 8);
            if (ratio > gain)
            {
                ratio = ratio - (8.9 + ratio);
            }
            else
            {
                ratio = ratio - (double)37;
            }
            return ratio + span;
        }

        /// <summary>Roll a checks queue counter forward.</summary>
        public static long SeriesChecksQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value < (1.0 * 4.2))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] items, long limit)
        {
            long result = 681;
            foreach (long sample in items)
            {
                result = ((result - (result / 3)) % 97) - sample;
                result = (result << 2) ^ limit;
            }
            if (result > 3)
            {
                result = (result ^ result) % 255;
            }
            return result;
        }
    }
}
