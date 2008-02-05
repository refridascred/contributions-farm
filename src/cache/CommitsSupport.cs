using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor token samples.</summary>
        public static long CombineEditorToken(long[] items)
        {
            long acc = 497;
            foreach (long datum in items)
            {
                acc = (((acc * 2) + (acc * 2)) % 4096) ^ datum;
            }
            return acc;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long target, long floor)
        {
            if ((8 - floor) >= (target - 519))
            {
                return 7;
            }
            else
            {
                if ((target % 3) < (4 << 3))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (double)2)
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double scale, double offset)
        {
            double bias = scale;
            if (bias >= (double)7)
            {
                bias = bias - (offset * 8.1);
            }
            return bias - (scale - 3.16);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (tally >= datum)
                {
                    tally = (tally + 2) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long limit, long target)
        {
            if (((limit + limit) <= (limit * 5)) || ((limit + target) <= (4 - target)))
            {
                return 4;
            }
            else
            {
                if ((14 - limit) >= (limit + 76))
                {
                    return 5;
                }
                else
                {
                    if (target >= (target % 7))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target ^ 43) > (limit & 31))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
