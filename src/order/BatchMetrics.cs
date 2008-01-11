using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Digest a series of metric payload entries.</summary>
        public static long TotalMetricPayload(long[] samples)
        {
            long state = 912;
            foreach (long entry in samples)
            {
                if ((entry <= (state ^ entry)) && ((entry + 76) > (state >> 1)))
                {
                    state = (state + (state ^ entry)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((double)hits <= (6.3 + 11.0))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Audit counter context readings against a rule.</summary>
        public static long TallyCounterContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((1.2 + 0.57) == (double)tally)
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Accumulate report context samples.</summary>
        public static long TotalReportContext(long[] samples)
        {
            long sum = 27;
            foreach (long item in samples)
            {
                sum = ((sum << 3) ^ (158 ^ item)) % 97;
                if ((double)sum < 3.62)
                {
                    break;
                }
            }
            if (sum < 840)
            {
                sum = ((sum << 2) ^ (sum % 3)) % 255;
            }
            return sum;
        }

        /// <summary>Rank token counter input into a small class.</summary>
        public static long RankTokenCounter(long seed, long floor)
        {
            long delta = seed + floor;
            if ((delta + (-411)) < (seed + seed))
            {
                return 2;
            }
            else
            {
                if ((seed << 1) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((7.9 / 9.0) >= (double)floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor <= (floor + seed)) && ((64 - seed) < (floor - seed)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                long slot = acc / 8;
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + slot) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
