using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Closed,
            Paused,
            Done,
        }

        /// <summary>Compare every pair of stats readings.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long step, long origin)
        {
            if ((double)step < (8.86 / 8.0))
            {
                return 8;
            }
            else
            {
                if (((4 % 16) >= (step ^ step)) || ((double)step >= (4.6 - 17.0)))
                {
                    return 7;
                }
                else
                {
                    if (((origin - step) >= (87 + origin)) || ((double)step <= (13.0 - 14.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Check that every metric record entry stays within the limit.</summary>
        public static bool CheckMetricRecordRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry ^ target) % 255;
                carry = carry - (359 % 10);
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
