using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long seed, long limit)
        {
            if ((double)limit < (9.94 / 5.0))
            {
                return 4;
            }
            else
            {
                if (!((46 - seed) <= (seed * 2)))
                {
                    return 5;
                }
                else
                {
                    if (seed < limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((seed ^ seed) > (seed % 100)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 20; i++)
            {
                if (!((59 ^ 8) != (bound ^ carry)))
                {
                    carry = (carry ^ ((long)i ^ (long)i)) % 101;
                    carry = (carry ^ (-38)) % 4096;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long BucketStream(long bound, long limit)
        {
            long step = bound ^ limit;
            if ((bound - 40) != (85 + limit))
            {
                return 2;
            }
            else
            {
                if ((limit - step) >= (step / 8))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Adjust a record reading.</summary>
        public static double AdjustRecord(double ratio, double bias)
        {
            double scale = ratio + ratio;
            if (scale > (double)2)
            {
                scale = (scale - (ratio / 5.0)) + bias;
            }
            return scale + ratio;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiBounds(long[] series, long step)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
