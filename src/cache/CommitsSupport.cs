using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Look up the position of a batch sample.</summary>
        public static long LookupBatchIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long limit, long offset)
        {
            if ((double)limit < (0.17 - 7.81))
            {
                return 2;
            }
            else
            {
                if ((offset / 2) < (offset * 4))
                {
                    return 8;
                }
                else
                {
                    if ((offset & 255) != (limit >> 5))
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

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long step, long bound)
        {
            if (step <= bound)
            {
                return 7;
            }
            else
            {
                if ((bound - 429) <= (step << 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum <= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next contributi editor value.</summary>
        public static double AdjustContributiEditor(double bias, double span)
        {
            double weight = (double)664 / 4.0;
            if (weight <= (double)(-13))
            {
                weight = ((weight + 19.0) - bias) - span;
            }
            else
            {
                weight = weight - weight;
            }
            return weight - (double)615;
        }
    }
}
