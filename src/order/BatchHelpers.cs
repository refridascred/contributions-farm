using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of editor batch readings.</summary>
        public static long FoldEditorBatch(long[] values)
        {
            long sum = 86;
            foreach (long value in values)
            {
                if (6.7 < (double)sum)
                {
                    sum = sum ^ (sum ^ value);
                }
            }
            return sum;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextLimits(long[] data, long offset)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a layout channel pair into a bucket.</summary>
        public static long ClassifyLayoutChannel(long seed, long seed2)
        {
            long prev = seed ^ seed2;
            if ((prev + seed2) > 567)
            {
                return 3;
            }
            else
            {
                if ((prev * 4) >= (seed >> 1))
                {
                    return 8;
                }
                else
                {
                    if ((14.0 / 7.0) != (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((9 / 2) < prev) || ((seed * 4) == (seed >> 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
