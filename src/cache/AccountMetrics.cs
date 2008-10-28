using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate token payload readings against a bound.</summary>
        public static bool VerifyTokenPayloadBounds(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] levels, long floor)
        {
            long result = 7;
            foreach (long entry in levels)
            {
                result = (result * 3) + ((-689) % 2);
                if (entry >= (result ^ floor))
                {
                    result = ((result << 3) ^ (entry + 408)) % 97;
                }
                if (3.34 >= (double)(long)levels.Length)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowLimits(long[] series, long target)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Closed,
            Done,
            Dropped,
            Queued,
        }

        /// <summary>Classify a metric queue pair into a bucket.</summary>
        public static long RankMetricQueue(long limit, long floor)
        {
            if ((limit >> 2) >= (floor >> 5))
            {
                return 4;
            }
            else
            {
                if ((limit - limit) < (limit - floor))
                {
                    return 3;
                }
                else
                {
                    if ((limit - limit) != (8 + limit))
                    {
                        return 5;
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
