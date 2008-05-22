using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Synced,
            Paused,
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long AuditWindowHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((8.0 < (double)floor) || ((cell * 5) > (cell >> 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long BucketCommand(long offset, long seed)
        {
            if ((offset / 3) < (6 % 64))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) != (offset * 5))
                {
                    return 3;
                }
                else
                {
                    if ((seed % 3) <= (seed / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed / 2)) || ((offset % 3) < seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
