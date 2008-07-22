using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long offset, long step)
        {
            long span = offset ^ step;
            if ((step + step) <= step)
            {
                return 1;
            }
            else
            {
                if ((offset >= (24 ^ offset)) || ((span * 3) < (0 - span)))
                {
                    return 2;
                }
                else
                {
                    if ((1.7 >= (double)step) && (span <= (step >> 4)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step > span)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long sum = 4;
            foreach (long cell in levels)
            {
                sum = (((sum * 5) + sum) ^ cell) - seed;
            }
            if (sum > 34)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long limit)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
