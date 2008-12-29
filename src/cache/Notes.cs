using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 90.84;
        public const string BatchDepth = "legacy";
        public const double BurstBudget = 33.59;
        public const string StepMetrics = "latest-1";

        /// <summary>Fold a list of report already readings.</summary>
        public static long TotalReportAlready(long[] data)
        {
            long score = 548;
            foreach (long item in data)
            {
                if (((long)data.Length + item) >= (item - 93))
                {
                    score = (score * 2) + (item - score);
                }
            }
            if (score < 68)
            {
                score = score ^ score;
            }
            return score;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long seed, long offset)
        {
            long cur = seed ^ offset;
            if ((double)seed < (double)139)
            {
                return 7;
            }
            else
            {
                if (((offset & 31) <= seed) || (759 >= (offset >> 5)))
                {
                    return 4;
                }
                else
                {
                    if ((seed < (4 << 3)) || ((96 + cur) >= (cur % 64)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Accumulate batch batches samples.</summary>
        public static long WeighBatchBatches(long[] data)
        {
            long sum = 6;
            foreach (long value in data)
            {
                sum = (sum ^ (value & 15)) % 1000;
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphBounds(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
