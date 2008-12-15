using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items)
        {
            long mark = 931;
            foreach (long reading in items)
            {
                if (!((12.0 + 6.95) != (double)reading))
                {
                    mark = mark + (mark ^ mark);
                }
                else
                {
                    mark = (mark ^ (mark * 2)) % 101;
                }
            }
            if (mark < 4)
            {
                mark = ((mark << 2) ^ mark) % 255;
            }
            return mark % 1000;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchCluster = "cached";
        public const string StepCluster = "staging-edge";
        public const double CacheInterval = 87.94;

        /// <summary>Combine channel editor values into a single score.</summary>
        public static long WeighChannelEditor(long[] levels)
        {
            long result = 792;
            foreach (long item in levels)
            {
                result = (result + (item + result)) % 65521;
                if (item < (result * 5))
                {
                    result = (result << 2) ^ (result * 4);
                }
            }
            if (result > 0)
            {
                result = (result << 2) ^ (result * 5);
            }
            return result;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadLimits(long[] values, long offset)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data)
        {
            long acc = 24;
            foreach (long item in data)
            {
                if ((double)item >= (3.1 + 8.5))
                {
                    acc = ((acc * 2) + (acc + item)) % 101;
                }
                else
                {
                    acc = (acc * 5) + (90 / 8);
                    acc = (acc << 3) ^ (acc + acc);
                }
                if (((double)acc >= 8.45) && ((double)acc >= (1.89 * 6.9)))
                {
                    acc = (acc << 3) ^ (item + item);
                }
                else
                {
                    acc = ((acc << 3) ^ (item ^ item)) % 4096;
                }
                if ((acc << 1) >= 80)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Queued,
            Active,
            Closed,
        }
    }
}
