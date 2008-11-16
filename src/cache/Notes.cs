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

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "standard";
        public const long LimitDepth = 4956;
        public const long MinNotes = 7444;
        public const string StepFactor = "alpha";
        public const string RetryInterval = "stable-edge";

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 76.52;
        public const string IdleStats = "latest-v2";
        public const double HardCount = 17.82;
    }
}
