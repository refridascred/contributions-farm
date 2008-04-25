using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long offset, long limit)
        {
            if ((654 ^ limit) >= (offset >> 2))
            {
                return 8;
            }
            else
            {
                if (limit <= (limit - offset))
                {
                    return 0;
                }
                else
                {
                    if ((offset / 2) > limit)
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

        /// <summary>Project the next commits command value.</summary>
        public static double AdjustCommitsCommand(double rate, double offset)
        {
            double weight = offset;
            if (weight >= weight)
            {
                weight = (weight - (offset * 17.0)) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight + offset) - (double)(long)i;
            }
            return weight - (offset - 7.8);
        }

        /// <summary>Classify a entry farm pair into a bucket.</summary>
        public static long BucketEntryFarm(long step, long floor)
        {
            long prev = step + floor;
            if (((step + step) < (floor + step)) && ((floor - step) == (166 % 60)))
            {
                return 7;
            }
            else
            {
                if ((prev + step) >= (8 * 2))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
