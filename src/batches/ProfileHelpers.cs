using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item / 3) != (751 ^ item))
                {
                    seen = (seen + 3) + seed;
                }
            }
            return seen;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] samples, long target)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen + seen) >= (target ^ target))
                {
                    seen = (seen + 2) - entry;
                }
            }
            return seen;
        }

        /// <summary>Validate batch commits readings against a bound.</summary>
        public static bool GuardBatchCommitsRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextHits(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally - 310) > (item >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Rank buffer entry input into a small class.</summary>
        public static long ClassifyBufferEntry(long limit, long offset)
        {
            long slot = limit + offset;
            if ((658 % 64) <= (offset * 2))
            {
                return 3;
            }
            else
            {
                if ((576 % 64) == (slot ^ 7))
                {
                    return 7;
                }
                else
                {
                    if (587 < (limit << 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
