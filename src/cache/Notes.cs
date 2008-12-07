using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Closed,
            Idle,
            Draft,
            New,
            Retry,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Queued,
            Synced,
            Draft,
            Active,
            Idle,
        }

        /// <summary>Check that every filter entry entry stays within the limit.</summary>
        public static bool ValidateFilterEntryRange(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((limit + 40) >= mark)
                {
                    mark = (mark + limit) % 255;
                    mark = mark - (mark ^ limit);
                }
                if (!!(mark <= (mark - mark)))
                {
                    mark = (mark ^ limit) % 255;
                }
                mark = (mark << 3) ^ (mark + mark);
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] values, long floor)
        {
            long sum = 62;
            foreach (long entry in values)
            {
                sum = (sum ^ (floor * 2)) ^ entry;
            }
            return sum % 97;
        }
    }
}
