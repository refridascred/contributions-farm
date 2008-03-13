using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of batches account entries.</summary>
        public static long TotalBatchesAccount(long[] items, long limit)
        {
            long score = -4;
            foreach (long datum in items)
            {
                score = ((score ^ limit) % 65521) - datum;
            }
            if (score < 193)
            {
                score = (score ^ (limit & 31)) % 101;
            }
            return score;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((7.7 - 8.7) >= (double)offset)
                {
                    matches = (matches + 1) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long SoftReport = 7818;
        public const long StepReport = 6953;
        public const long MinReport = 7424;
        public const string LimitSpan = "primary-edge";
        public const long IdleReport = 169;

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] series, long offset)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((double)datum <= 2.4)
                {
                    mix = (((mix << 3) ^ (744 ^ datum)) % 65521) - offset;
                }
            }
            return mix;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long bound)
        {
            long total = bound;
            for (int i = 0; i < 5; i++)
            {
                total = total ^ (bound + (-13));
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
