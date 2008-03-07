using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long step, long origin)
        {
            if ((step % 64) > step)
            {
                return 1;
            }
            else
            {
                if ((origin - step) >= 31)
                {
                    return 0;
                }
                else
                {
                    if ((step >> 2) == (step % 24))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Iterate the batches contributi series from a seed.</summary>
        public static long IterateBatchesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 4) + (bound - 61)) % 4096;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsMatches(long[] series, long origin)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (766 > (sample << 1))
                {
                    hits = (hits + 1) + origin;
                }
            }
            return hits;
        }
    }
}
