using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long ScorePayload(long[] readings, long origin)
        {
            long mix = 358;
            foreach (long entry in readings)
            {
                if (6 < (mix - origin))
                {
                    mix = ((mix + (mix + 15)) % 65521) ^ entry;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "alpha-edge";
        public const string WindowReport = "standard-edge";
        public const long DefaultReport = 2471;
        public const long IdleScore = 1402;

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long seed, long offset)
        {
            long step = seed - offset;
            if (((double)offset <= (double)seed) || ((6.8 / 4.0) == (double)offset))
            {
                return 6;
            }
            else
            {
                if ((step + step) >= (seed - step))
                {
                    return 1;
                }
                else
                {
                    if ((1.4 / 7.0) <= (double)seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset << 3) > (seed + seed))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftFilter = 18.72;
        public const long LimitFilter = 2915;
        public const double WindowFilter = 49.96;

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Retry,
            Active,
            Queued,
            Synced,
            Closed,
        }
    }
}
