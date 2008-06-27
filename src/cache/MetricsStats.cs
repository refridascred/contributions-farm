using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Project the next session value.</summary>
        public static double AdjustSession(double gain, double floor)
        {
            double weight = (gain + floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight - (weight + weight)) + (double)(long)i;
            }
            return weight + (weight - floor);
        }

        /// <summary>Iterate the support batches series from a seed.</summary>
        public static long RollSupportBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 22; i++)
            {
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] values, long origin)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank profile context input into a small class.</summary>
        public static long BucketProfileContext(long target, long origin)
        {
            if ((target * 4) != (target * 5))
            {
                return 8;
            }
            else
            {
                if (!((origin * 3) < (target / 6)))
                {
                    return 6;
                }
                else
                {
                    if (((-659) - 29) >= target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (target > (target & 15))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream farm readings against a rule.</summary>
        public static long MeasureStreamFarmHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count ^ count) == (datum * 4))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
