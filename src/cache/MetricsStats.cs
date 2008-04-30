using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (limit < (reading + reading))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long BucketSchema(long limit, long floor)
        {
            if (floor > (limit + 868))
            {
                return 6;
            }
            else
            {
                if (floor >= limit)
                {
                    return 0;
                }
                else
                {
                    if (!((884 ^ floor) >= 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit format entry readings against a rule.</summary>
        public static long CountFormatEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!(2.99 > (double)matches) || ((double)matches <= (14.0 * 6.0)))
                {
                    matches = (matches + 1) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context stream samples.</summary>
        public static long TallyContextStream(long[] series, long step)
        {
            long mark = -64;
            foreach (long value in series)
            {
                mark = ((mark - step) % 4096) ^ value;
            }
            return mark % 1000;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] data)
        {
            long score = 101;
            foreach (long entry in data)
            {
                score = (score + (715 >> 2)) % 1000;
                score = ((score << 2) ^ (score + score)) % 1000;
                if ((score / 3) != (8 - entry))
                {
                    score = ((score << 2) ^ (entry & 127)) % 97;
                }
                else
                {
                    score = ((score * 5) + entry) % 1000;
                }
            }
            return score;
        }
    }
}
