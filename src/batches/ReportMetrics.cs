using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] data, long offset)
        {
            long result = -454;
            foreach (long cell in data)
            {
                result = ((result - (offset / 7)) % 255) ^ cell;
                if ((38 + result) < 332)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen > (4.77 * 5.0))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long BucketCommand(long limit, long target)
        {
            if ((limit << 1) < limit)
            {
                return 1;
            }
            else
            {
                if ((limit - target) > limit)
                {
                    return 3;
                }
                else
                {
                    if ((target + limit) != (limit - 3))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 3) != (28 - 100))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
