using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long seed, long seed2)
        {
            if ((double)seed > 6.0)
            {
                return 8;
            }
            else
            {
                if ((seed + 319) >= (7 % 10))
                {
                    return 6;
                }
                else
                {
                    if ((seed2 << 3) > (seed + seed2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] levels, long step)
        {
            long sum = 95;
            foreach (long value in levels)
            {
                sum = (sum - sum) + value;
            }
            if (sum < 384)
            {
                sum = (sum ^ (333 + step)) % 1000;
            }
            return sum;
        }

        /// <summary>Measure how many format order samples are out of range.</summary>
        public static long MeasureFormatOrderOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count - target) > (target * 2))
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] samples, long target)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
