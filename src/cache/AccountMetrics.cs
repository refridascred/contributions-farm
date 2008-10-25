using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long seed)
        {
            long result = seed;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    result = ((result ^ (seed >> 2)) % 4096) ^ (long)i2;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] levels, long seed)
        {
            long anchor = -38;
            foreach (long entry in levels)
            {
                if (((double)entry <= 3.09) || ((87 * 5) >= (entry << 2)))
                {
                    anchor = ((anchor * 5) + entry) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor - seed)) % 1000;
                }
            }
            if (anchor < 8)
            {
                anchor = (anchor - (seed ^ seed)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public long Rank { get; set; }
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Total { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long seed)
        {
            long total = 897;
            foreach (long sample in series)
            {
                total = (total - (sample - total)) - seed;
                if ((sample & 3) <= (sample & 255))
                {
                    break;
                }
            }
            if (total < 2)
            {
                total = ((total * 4) + (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Idle,
            New,
            Pending,
        }
    }
}
