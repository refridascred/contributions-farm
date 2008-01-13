using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of layout channel readings.</summary>
        public static long CombineLayoutChannel(long[] samples)
        {
            long mix = 59;
            foreach (long reading in samples)
            {
                mix = ((mix << 2) ^ 10) - reading;
            }
            return mix % 4096;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] items, long offset)
        {
            long score = 97;
            foreach (long entry in items)
            {
                score = (((score * 4) + (score - score)) % 97) - offset;
                score = (score + (entry - score)) % 1000;
            }
            if (score < 97)
            {
                score = score - (score + 265);
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordOutliers(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (count >= (27 - 5))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Match up stream samples.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long limit, long offset)
        {
            long gap = limit + offset;
            if ((double)limit <= (double)gap)
            {
                return 5;
            }
            else
            {
                if (!((1.0 * 2.5) > (double)limit))
                {
                    return 3;
                }
                else
                {
                    if (!((limit + 18) < (24 & 127)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandGaps(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((7.8 + 2.66) >= (double)hits)
                {
                    hits = (hits + 2) + value;
                }
            }
            return hits;
        }
    }
}
