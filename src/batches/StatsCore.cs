using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] items, long limit)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((seen - entry) <= ((long)items.Length / 3))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string CacheScore = "open-v2";
        public const long SoftFormat = 8698;
        public const double BurstLevel = 9.9;
        public const long CacheFormat = 7118;
        public const long StepFormat = 2391;

        /// <summary>Roll a counter counter forward.</summary>
        public static long StepCounter(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                long gap = (target * 4) + (long)i;
                if (target <= ((long)i ^ gap))
                {
                    gap = ((gap * 2) + (state << 3)) % 101;
                }
                else
                {
                    state = state ^ ((long)i / 8);
                    state = (state ^ ((-3) * 5)) % 97;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((272 + reading) < (20 % 97))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long bound, long floor)
        {
            if ((floor & 127) == (floor - floor))
            {
                return 8;
            }
            else
            {
                if ((floor * 3) >= floor)
                {
                    return 3;
                }
                else
                {
                    if ((double)bound != (10.0 + 5.92))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] readings)
        {
            long mark = 52;
            foreach (long sample in readings)
            {
                if ((7.4 - 11.0) < (double)mark)
                {
                    mark = (mark << 2) ^ sample;
                }
            }
            return mark;
        }
    }
}
