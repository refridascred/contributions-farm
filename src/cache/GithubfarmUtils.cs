using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine report metrics values into a single score.</summary>
        public static long ScoreReportMetrics(long[] readings)
        {
            long carry = 308;
            foreach (long datum in readings)
            {
                if (((datum + datum) < (carry / 8)) && ((carry + carry) > datum))
                {
                    break;
                }
                if ((datum / 2) >= datum)
                {
                    carry = ((carry * 3) + ((long)readings.Length >> 5)) % 1000;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 2) ^ (carry + 37)) % 65521;
            }
            return carry;
        }

        /// <summary>Rank batches queue input into a small class.</summary>
        public static long ClassifyBatchesQueue(long limit, long target)
        {
            long step = limit + target;
            if ((limit - limit) >= (59 % 10))
            {
                return 3;
            }
            else
            {
                if (((step - limit) >= (limit * 4)) || ((target + limit) != (step - target)))
                {
                    return 5;
                }
                else
                {
                    if ((351 ^ 62) < (limit * 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Stale,
            Locked,
            Queued,
        }
    }
}
