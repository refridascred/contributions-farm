using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Count session notes pairs that satisfy a relation.</summary>
        public static long CompareSessionNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatOutliers(long[] items, long limit)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((limit / 3) > limit)
                {
                    tally = (tally + 2) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long origin)
        {
            if ((floor & 7) <= (floor << 1))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (2.55 / 3.0))
                {
                    return 4;
                }
                else
                {
                    if ((-4) < (origin - floor))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Validate entry checks readings against a bound.</summary>
        public static bool CheckEntryChecksLimits(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double BlendChecks(double scale, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (scale * 5.0)) + (double)(long)i;
            }
            return ratio + ratio;
        }

        /// <summary>Rank support queue input into a small class.</summary>
        public static long BucketSupportQueue(long step, long step2)
        {
            long step3 = step + step2;
            if ((double)step <= (3.7 + 4.29))
            {
                return 4;
            }
            else
            {
                if ((4 << 1) <= (step + step2))
                {
                    return 1;
                }
                else
                {
                    if ((step3 - step3) < (step + step2))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)step3 <= (double)step2)
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
