using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a checks counter pair into a bucket.</summary>
        public static long GradeChecksCounter(long target, long bound)
        {
            if (((284 - bound) != (410 >> 4)) || ((double)target == (9.1 * 1.0)))
            {
                return 6;
            }
            else
            {
                if ((double)bound >= (7.7 + 2.51))
                {
                    return 8;
                }
                else
                {
                    if (bound > 0)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryHits(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample + tally) > (sample >> 1))
                {
                    tally = (tally + 2) + floor;
                }
            }
            return tally;
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

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
