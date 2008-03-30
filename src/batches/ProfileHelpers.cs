using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + hits) != (675 << 3))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
