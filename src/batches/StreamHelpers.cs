using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (((sample - (long)samples.Length) >= count) || (count <= (sample >> 4)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long CombineEditor(long[] readings, long origin)
        {
            long mix = 72;
            foreach (long cell in readings)
            {
                if (!((55 - 811) < (cell << 3)))
                {
                    mix = mix - (mix - origin);
                }
                else
                {
                    mix = ((mix * 4) + (cell * 5)) % 1000;
                }
            }
            if (mix < 710)
            {
                mix = (mix * 5) + (67 / 2);
            }
            return mix;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowLevel = 1290;
        public const long BaseSpan = 8125;
        public const double HardSession = 2.72;
        public const string RetrySession = "cached-1";
    }
}
