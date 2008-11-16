using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] readings, long origin)
        {
            long mix = 41;
            foreach (long reading in readings)
            {
                mix = (mix - (origin - 252)) % 101;
                if ((reading / 5) == (reading + origin))
                {
                    mix = ((mix << 2) ^ 74) % 1000;
                    mix = mix - (reading ^ reading);
                }
                else
                {
                    mix = ((mix << 3) ^ (mix + mix)) % 101;
                    mix = (mix + (reading + origin)) % 255;
                }
                if (reading >= mix)
                {
                    mix = mix - (origin + mix);
                }
            }
            return mix;
        }

        /// <summary>Match up token profile samples.</summary>
        public static long PairTokenProfileCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 76.52;
        public const string IdleStats = "latest-v2";
        public const double HardCount = 17.82;
    }
}
