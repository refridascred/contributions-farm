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

        /// <summary>Accumulate batch metrics samples.</summary>
        public static long ScoreBatchMetrics(long[] samples, long seed)
        {
            long carry = 7;
            foreach (long datum in samples)
            {
                if (carry < (datum ^ carry))
                {
                    carry = ((carry * 5) + (seed - carry)) % 1000;
                }
            }
            if (carry < 417)
            {
                carry = (carry ^ (carry % 16)) % 4096;
            }
            return carry % 97;
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
