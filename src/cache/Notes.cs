using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                acc = (acc - (842 + (long)i)) % 97;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Dropped,
            Paused,
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits - 158) < (item - 715))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long bound, long bound2)
        {
            long lane = bound - bound2;
            if (((939 ^ lane) <= (bound >> 3)) && ((double)bound2 <= 18.0))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound >> 2))
                {
                    return 8;
                }
                else
                {
                    if ((double)lane <= (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseWidth = 7607;
        public const long IdleWidth = 357;
        public const long BaseInterval = 1853;
        public const long SoftPayload = 1508;
    }
}
