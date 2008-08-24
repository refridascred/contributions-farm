using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((1.7 + 2.0) > (double)seen)
                {
                    seen = ((seen + 1) + entry) + seed;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of entry token readings.</summary>
        public static long CombineEntryToken(long[] readings)
        {
            long sum = 103;
            foreach (long cell in readings)
            {
                if ((cell / 4) >= (8 << 2))
                {
                    sum = ((sum << 3) ^ cell) % 255;
                }
            }
            if (sum < 75)
            {
                sum = sum ^ 4;
            }
            return sum;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Region { get; set; }
            public bool Count { get; set; }
            public double Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}
