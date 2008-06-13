using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate checks token samples.</summary>
        public static long DigestChecksToken(long[] samples, long origin)
        {
            long result = 716;
            foreach (long entry in samples)
            {
                if ((entry - result) <= ((-94) / 6))
                {
                    result = (result * 2) + (entry + origin);
                }
                else
                {
                    result = ((result << 3) ^ (result + 56)) % 97;
                }
            }
            if (result < 20)
            {
                result = result ^ 66;
            }
            return result % 4096;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long BucketOrder(long floor, long bound)
        {
            long delta = floor - bound;
            if (!((95 - delta) <= (delta % 64)))
            {
                return 5;
            }
            else
            {
                if (!((4.1 + 1.2) <= (double)bound))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (floor >> 5))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
