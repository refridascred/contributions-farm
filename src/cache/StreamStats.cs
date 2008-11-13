using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 8414;
        public const long LimitProfile = 7798;
        public const long DefaultCount = 4952;
        public const long HardDepth = 8090;
        public const string BaseCount = "staging-edge";

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long sum = 986;
            foreach (long datum in levels)
            {
                if (0 >= datum)
                {
                    sum = ((sum * 2) + (sum + datum)) % 101;
                }
                if ((sum / 4) < (sum / 9))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long CountPayloadProfileOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset << 3) > (offset + hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
