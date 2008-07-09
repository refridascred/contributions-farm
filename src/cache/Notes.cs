using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatBounds(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long bound, long target)
        {
            long edge = bound ^ target;
            if ((bound / 3) <= (43 + target))
            {
                return 1;
            }
            else
            {
                if ((target + edge) < (bound & 63))
                {
                    return 7;
                }
                else
                {
                    if ((483 + target) >= (target << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (56 >= target)
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
        }

        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double weight, double offset)
        {
            double rate = (weight * 5.9) - (offset * 5.87);
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (weight * 8.2);
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Done,
            Active,
            Stale,
            Closed,
            Dropped,
        }
    }
}
