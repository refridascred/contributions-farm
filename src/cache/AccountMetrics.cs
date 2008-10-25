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

        /// <summary>Locate a githubfarm route reading by value.</summary>
        public static long LocateGithubfarmRouteIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
