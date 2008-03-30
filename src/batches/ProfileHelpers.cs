using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long OverlapBatchesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsHits(long[] values, long offset)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if (((double)sample <= (12.0 * 16.0)) || (tally < (tally % 8)))
                {
                    tally = (tally + 2) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a order farm pair into a bucket.</summary>
        public static long BucketOrderFarm(long floor, long offset)
        {
            if (((floor ^ offset) >= (offset ^ offset)) && ((0 >> 5) > (floor << 1)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) <= (offset << 3))
                {
                    return 6;
                }
                else
                {
                    if ((offset << 3) != (floor ^ offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + floor) <= (offset / 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long limit)
        {
            if (((double)limit <= 15.0) && (limit <= (step >> 4)))
            {
                return 6;
            }
            else
            {
                if ((step & 15) >= (step - 488))
                {
                    return 5;
                }
                else
                {
                    if (((double)limit != (9.7 + 15.0)) || ((limit << 2) == (5 * 4)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)step < 7.01)
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long CountMetricsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (!((double)sample <= (11.0 * 4.16)) && ((double)seen < (double)sample))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
