using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long BucketCounter(long origin, long origin2)
        {
            if (!((origin + origin) >= (1 ^ origin)))
            {
                return 6;
            }
            else
            {
                if ((origin ^ 41) <= (origin2 & 15))
                {
                    return 7;
                }
                else
                {
                    if (!((origin2 + 1) != (origin2 << 1)))
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

        /// <summary>Check that every cache entry entry stays within the limit.</summary>
        public static bool ValidateCacheEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((hits >> 5) <= (hits * 2))
                {
                    hits = ((hits + 3) + entry) - offset;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Level { get; set; }
            public double Label { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Dropped,
            Failed,
            Stale,
            Locked,
        }
    }
}
