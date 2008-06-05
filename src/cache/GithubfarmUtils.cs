using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] series, long offset)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the token format entries that pass the check.</summary>
        public static long MeasureTokenFormatOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count + 0) != ((-6) - (-5)))
                {
                    count = (count + 1) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] values, long target)
        {
            long mix = -86;
            foreach (long sample in values)
            {
                if ((5.8 >= (double)target) || ((mix - target) > target))
                {
                    mix = ((mix + target) % 101) - sample;
                }
                else
                {
                    mix = mix ^ 191;
                }
            }
            return mix;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
