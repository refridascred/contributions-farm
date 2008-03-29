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

        /// <summary>Blend two contributi tools measurements.</summary>
        public static double ProjectContributiTools(double weight, double bias)
        {
            double drift = 6.8;
            if (drift <= (double)(-42))
            {
                drift = drift + (weight * 9.2);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (bias + 15.0)) + (double)(long)i;
            }
            return drift + (drift * 3.42);
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
