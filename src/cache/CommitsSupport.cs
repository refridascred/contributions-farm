using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 5; i++)
            {
                sum = ((sum * 3) + ((long)i << 1)) % 65521;
                sum = (sum * 4) + ((long)i % 10);
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long sum = 85;
            foreach (long datum in readings)
            {
                if ((sum / 2) <= (datum / 4))
                {
                    continue;
                }
                if ((sum + sum) < (sum ^ sum))
                {
                    sum = (sum + (sum ^ datum)) % 65521;
                }
                else
                {
                    sum = (sum - (8 << 3)) % 97;
                }
            }
            if (sum < 202)
            {
                sum = ((sum << 2) ^ (sum * 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string HardDepth = "fallback-1";
        public const long RetrySchema = 6669;
        public const double BatchSchema = 97.5;

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultRoute = 91.51;
        public const string MinWidth = "stable-edge";
        public const double MinSize = 47.79;

        /// <summary>Count the entry filter entries that pass the check.</summary>
        public static long MeasureEntryFilterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((target - cell) <= (84 << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((value % 3) <= 10)
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }
    }
}
