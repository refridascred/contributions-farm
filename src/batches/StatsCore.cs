using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit support report readings against a rule.</summary>
        public static long TallySupportReportGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (3 > hits)
                {
                    hits = ((hits + 1) - entry) - floor;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public long Limit { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryTimeout = 8707;
        public const double IdleInterval = 17.35;
        public const long BatchBuffer = 4079;
        public const long CacheWidth = 7510;

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long result = 568;
            foreach (long datum in data)
            {
                if (result < (datum << 3))
                {
                    result = ((result ^ ((-15) & 3)) % 65521) - bound;
                }
            }
            if (result < 386)
            {
                result = result ^ result;
            }
            return result;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long offset, long step)
        {
            if ((step * 4) < (offset - step))
            {
                return 8;
            }
            else
            {
                if ((double)step < 9.5)
                {
                    return 0;
                }
                else
                {
                    if ((double)step >= (3.93 + 16.0))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step - step) != (offset * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
