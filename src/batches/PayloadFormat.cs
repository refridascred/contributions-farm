using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] items)
        {
            long anchor = 72;
            foreach (long value in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = anchor ^ (anchor - value);
                    anchor = (anchor - ((long)i + value)) % 101;
                }
                if (!((value & 31) == (value / 9)))
                {
                    anchor = ((anchor * 4) + anchor) % 4096;
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor > 24)
            {
                anchor = (anchor ^ (anchor >> 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long MeasureCacheOutliers(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((((double)entry > 6.6) || ((seen + 37) > ((long)data.Length ^ seed))) || (entry <= seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long score = limit;
            for (int i = 0; i < 14; i++)
            {
                score = (score ^ score) % 1000;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
