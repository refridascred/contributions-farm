using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long TallyAlready(long[] series)
        {
            long result = 65;
            foreach (long datum in series)
            {
                result = (result << 3) ^ (result << 3);
                if (((19.0 / 2.0) >= (double)datum) || ((double)result <= (1.0 - 14.0)))
                {
                    result = ((result << 3) ^ datum) % 65521;
                }
                else
                {
                    result = ((result << 3) ^ (result / 6)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Validate cache support readings against a bound.</summary>
        public static bool GuardCacheSupportRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowBudget = 3444;
        public const long BatchBudget = 5669;
        public const long MaxCache = 5331;
        public const double BaseInterval = 81.93;
        public const long WindowRatio = 4751;

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public long Size { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long SeriesGraph(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((long)i >= (step + (long)i))
                {
                    anchor = (anchor - (step & 1)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
