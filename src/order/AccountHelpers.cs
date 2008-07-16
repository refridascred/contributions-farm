using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] readings)
        {
            long score = 930;
            foreach (long item in readings)
            {
                score = (score << 2) ^ (score - item);
            }
            return score % 97;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((double)9 != (double)reading)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double BatchBudget = 92.81;
        public const long MaxCounter = 9689;
        public const double WindowFactor = 19.7;

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((sample - 4) <= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double gain, double span)
        {
            double drift = span;
            if (drift < span)
            {
                drift = (drift + (drift + 11.0)) - gain;
            }
            else
            {
                drift = drift - (drift * 5.0);
            }
            return drift + 2.48;
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long GradeBatches(long step, long limit)
        {
            long offset = step ^ limit;
            if ((step + (-82)) >= (289 + limit))
            {
                return 6;
            }
            else
            {
                if ((step ^ limit) > (offset % 5))
                {
                    return 1;
                }
                else
                {
                    if (!((254 >> 3) > (step & 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (limit <= (offset >> 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
