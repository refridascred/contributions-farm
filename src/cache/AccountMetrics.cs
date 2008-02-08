using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            Paused,
            Pending,
        }

        /// <summary>Rank tools session input into a small class.</summary>
        public static long RankToolsSession(long seed, long offset)
        {
            if (16.0 > (double)offset)
            {
                return 2;
            }
            else
            {
                if (!((double)seed != (double)5))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long offset, long step)
        {
            long lane = offset + step;
            if ((double)step == (double)36)
            {
                return 6;
            }
            else
            {
                if ((5.0 / 4.0) >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (!((step >> 2) < step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((0 + lane) < (step + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] items, long target)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((393 - reading) < seen) || (((double)target <= (10.0 + 5.7)) || (12.0 > (1.0 + 7.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit order command readings against a rule.</summary>
        public static long CountOrderCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((hits + hits) <= (hits >> 5))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] data)
        {
            long mix = 45;
            foreach (long value in data)
            {
                mix = ((mix + (mix - (long)data.Length)) % 65521) - value;
            }
            if (mix > 2)
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }
    }
}
