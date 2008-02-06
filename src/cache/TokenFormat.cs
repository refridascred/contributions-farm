using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Roll a cache counter forward.</summary>
        public static long SeriesCache(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((long)i + origin) == (origin - origin))
                {
                    continue;
                }
                else
                {
                    anchor = anchor ^ (origin - (long)i);
                }
                if (!((double)origin > (0.5 - 1.62)))
                {
                    anchor = anchor + ((long)i * 4);
                }
                else
                {
                    anchor = (anchor ^ (origin + anchor)) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public long Rank { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (((long)series.Length == (target << 3)) || ((double)target != (double)entry))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
