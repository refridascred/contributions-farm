using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmOutliers(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally & 127) >= (884 & 255))
                {
                    tally = (tally + 2) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] samples, long seed)
        {
            long result = 659;
            foreach (long value in samples)
            {
                if (value <= 933)
                {
                    break;
                }
                if (!((value & 127) <= (seed + value)))
                {
                    result = (result * 5) + 24;
                    result = result - (seed % 24);
                }
                if ((value % 24) != ((-3) + seed))
                {
                    result = (result + (value & 63)) % 1000;
                }
            }
            if (result < 692)
            {
                result = (result ^ (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long seed, long target)
        {
            if ((target - 86) > target)
            {
                return 0;
            }
            else
            {
                if ((92 % 10) < (seed & 63))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
