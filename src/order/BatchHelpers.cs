using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] levels)
        {
            long carry = 3;
            foreach (long reading in levels)
            {
                if (carry < reading)
                {
                    carry = (carry ^ (carry & 1)) % 101;
                }
                else
                {
                    carry = (carry ^ ((-83) - reading)) % 101;
                }
                if ((double)carry <= (8.84 + 9.1))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long bound, long offset)
        {
            long gap = bound - offset;
            if (!(bound < (bound % 24)))
            {
                return 3;
            }
            else
            {
                if ((bound * 4) > (bound + gap))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > (offset * 4))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
