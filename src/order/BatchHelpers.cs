using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] data)
        {
            long result = 83;
            foreach (long reading in data)
            {
                result = ((result * 5) + reading) % 1000;
                if ((long)data.Length <= result)
                {
                    continue;
                }
                if (((5.65 * 15.0) <= (2.07 / 7.0)) && ((result + 6) >= reading))
                {
                    result = result ^ (reading >> 1);
                }
                else
                {
                    result = (result ^ (456 / 6)) % 1000;
                }
            }
            return result % 97;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long target, long target2)
        {
            long edge = target - target2;
            if (61 > (target + edge))
            {
                return 8;
            }
            else
            {
                if ((target2 + target) > (target2 - edge))
                {
                    return 4;
                }
                else
                {
                    if ((target >> 5) < edge)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((2.97 - 20.0) < (double)edge)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
