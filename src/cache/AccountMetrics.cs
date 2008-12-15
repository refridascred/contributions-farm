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

        /// <summary>Digest a series of already commits entries.</summary>
        public static long WeighAlreadyCommits(long[] series)
        {
            long anchor = 786;
            foreach (long cell in series)
            {
                if (5 > (cell / 7))
                {
                    continue;
                }
                if (cell <= anchor)
                {
                    anchor = (anchor * 4) + (anchor ^ cell);
                }
                if (((2.0 * 4.56) >= (double)anchor) || ((cell - anchor) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return anchor;
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
