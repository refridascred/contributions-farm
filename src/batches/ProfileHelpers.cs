using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long floor)
        {
            long anchor = 26;
            foreach (long item in samples)
            {
                anchor = ((anchor * 3) + (anchor * 4)) - item;
            }
            if (anchor > 197)
            {
                anchor = ((anchor * 2) + (floor + floor)) % 255;
            }
            return anchor;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long AuditCommitsHits(long[] series, long limit)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen + reading) >= 163)
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double MinLevel = 55.63;
        public const long MinBatch = 6836;
        public const double BurstScore = 21.69;
        public const double HardBatch = 52.31;

        /// <summary>Rank record order input into a small class.</summary>
        public static long ClassifyRecordOrder(long seed, long offset)
        {
            long cur = seed + offset;
            if (!(cur > seed))
            {
                return 0;
            }
            else
            {
                if (((cur * 4) != (cur - seed)) && ((seed / 4) == (seed + offset)))
                {
                    return 2;
                }
                else
                {
                    if ((double)3 >= (double)offset)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((0.02 / 3.0) < (double)cur)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record layout samples.</summary>
        public static long PairRecordLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
