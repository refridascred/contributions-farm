using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)target != (10.0 + 2.1))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] values)
        {
            long sum = 274;
            foreach (long item in values)
            {
                if ((sum << 1) >= (item & 1))
                {
                    sum = ((sum << 2) ^ (sum >> 1)) % 101;
                }
                if (((double)item == (double)sum) || ((sum + item) <= sum))
                {
                    sum = (sum * 2) + sum;
                }
            }
            return sum;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long origin, long offset)
        {
            long prev = origin ^ offset;
            if (((double)offset != (double)25) || ((offset << 1) >= origin))
            {
                return 0;
            }
            else
            {
                if (((offset >> 4) <= offset) || ((8 & 255) <= (origin ^ 61)))
                {
                    return 2;
                }
                else
                {
                    if (((prev ^ prev) >= (prev / 7)) || ((origin + offset) >= (offset / 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((prev - offset) == (offset & 255)) || ((6.0 + 7.1) < (double)prev))
                        {
                            return 6;
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
