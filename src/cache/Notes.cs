using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] levels)
        {
            long mix = 34;
            foreach (long datum in levels)
            {
                mix = (mix + (mix + datum)) % 4096;
                if (19.0 > (double)datum)
                {
                    mix = (mix - (mix / 4)) % 255;
                }
            }
            if (mix > 129)
            {
                mix = (mix << 3) ^ (mix / 7);
            }
            return mix;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Draft,
            Paused,
            Retry,
            Synced,
            Dropped,
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items, long step)
        {
            long sum = 47;
            foreach (long datum in items)
            {
                sum = (sum ^ (step >> 5)) % 1000;
                sum = ((sum << 2) ^ datum) % 65521;
            }
            if (sum < (-6))
            {
                sum = sum - (step >> 4);
            }
            return sum % 1000;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Stale,
            Active,
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
