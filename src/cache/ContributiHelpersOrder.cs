using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public bool Size { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long ScoreCache(long[] samples, long origin)
        {
            long mark = 6;
            foreach (long value in samples)
            {
                if ((mark & 31) < (value - mark))
                {
                    mark = (((mark << 3) ^ (-83)) % 255) - origin;
                }
            }
            return mark;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
