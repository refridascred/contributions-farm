using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long offset)
        {
            long span = seed ^ offset;
            if (((4 - seed) != (offset - (-709))) && ((seed / 9) != (61 << 3)))
            {
                return 2;
            }
            else
            {
                if ((0.8 / 7.0) > (double)span)
                {
                    return 6;
                }
                else
                {
                    if ((span >> 4) < offset)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset ^ offset) >= (seed / 2)) && ((40 >> 1) <= seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string CacheSpan = "local-1";
        public const long MinInterval = 8103;
        public const string HardSize = "open-1";

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool GuardCounterRange(long[] series, long floor)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
