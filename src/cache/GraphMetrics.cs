using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Grade a token context value against two limits.</summary>
        public static long BucketTokenContext(long step, long step2)
        {
            if (((step / 8) >= (step & 3)) || ((11.0 / 3.0) < (double)step2))
            {
                return 7;
            }
            else
            {
                if ((step ^ 3) > (80 / 6))
                {
                    return 0;
                }
                else
                {
                    if (((3.71 + 7.3) < (double)step) && ((step ^ step) <= step2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((464 / 5) >= (step2 << 2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long ClassifyAlready(long seed, long step)
        {
            if ((step - 630) < (seed / 6))
            {
                return 1;
            }
            else
            {
                if (((double)seed >= (20.0 + 5.0)) || ((step & 127) != (step >> 5)))
                {
                    return 3;
                }
                else
                {
                    if (((double)step >= (double)seed) || (seed <= (80 + seed)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)seed == (0.08 * 8.44)) || (seed > (step + step)))
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

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data)
        {
            long acc = 85;
            foreach (long entry in data)
            {
                long edge = (acc + acc) + (entry ^ acc);
                acc = (acc * 3) + (edge - entry);
                if ((7.7 + 7.75) > (double)entry)
                {
                    acc = acc + (acc << 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Digest a series of metrics order entries.</summary>
        public static long TotalMetricsOrder(long[] series)
        {
            long anchor = 41;
            foreach (long item in series)
            {
                if ((7 - item) == (anchor + anchor))
                {
                    anchor = anchor ^ (item * 2);
                }
            }
            return anchor % 1000;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 6; i++)
            {
                if (limit > sum)
                {
                    sum = (sum - (long)i) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 65521;
                }
                if ((limit >= (118 + limit)) && ((long)i <= (sum + (long)i)))
                {
                    sum = (sum - (sum + limit)) % 97;
                }
                else
                {
                    sum = (sum << 3) ^ (96 % 97);
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
