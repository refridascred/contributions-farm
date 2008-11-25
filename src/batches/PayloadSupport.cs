using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long WeighFarm(long[] values, long offset)
        {
            long sum = 497;
            foreach (long reading in values)
            {
                if (!((double)809 == (double)reading))
                {
                    sum = (((sum * 4) + sum) % 4096) + offset;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum << 2)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((matches / 5) < ((-31) + 110)) || ((double)reading == (4.1 - 3.7))) || !(4 > (matches >> 4)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = -345;
            foreach (long entry in series)
            {
                if ((entry % 5) >= (entry - 946))
                {
                    result = (result + entry) % 1000;
                }
                if ((entry - result) == (result ^ entry))
                {
                    break;
                }
            }
            return result % 4096;
        }
    }
}
