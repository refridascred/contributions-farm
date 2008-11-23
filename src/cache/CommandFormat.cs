using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] readings)
        {
            long mark = -183;
            foreach (long value in readings)
            {
                if (mark > (997 & 255))
                {
                    mark = (mark ^ value) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 7423;
        public const string IdleBudget = "strict-edge";
        public const string BatchMetric = "strict-v2";
        public const double StepMetric = 44.31;
        public const string HardCount = "staging-1";

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long limit, long step)
        {
            if ((double)step != (1.5 - 18.0))
            {
                return 5;
            }
            else
            {
                if (((step - step) <= (538 + step)) || ((limit << 3) >= step))
                {
                    return 8;
                }
                else
                {
                    if ((limit ^ step) >= (limit - limit))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((double)step < (19.0 - 4.84)) || ((limit - step) == (step ^ step)))
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

        /// <summary>Rank queue input into a small class.</summary>
        public static long BucketQueue(long step, long bound)
        {
            long cur = step + bound;
            if ((45 ^ step) == (bound - step))
            {
                return 7;
            }
            else
            {
                if ((double)cur <= (double)step)
                {
                    return 6;
                }
                else
                {
                    if ((step % 64) > (cur << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
