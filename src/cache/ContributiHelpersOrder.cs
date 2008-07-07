using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] items, long floor)
        {
            long sum = 91;
            foreach (long item in items)
            {
                long next = item + 6;
                if (!((double)next < (8.0 * 16.0)))
                {
                    next = (((next * 5) + (next + sum)) % 4096) - floor;
                }
                if ((double)sum <= 2.9)
                {
                    sum = (sum - (sum + sum)) % 4096;
                }
            }
            if (sum > 6)
            {
                sum = (sum + (sum & 7)) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Audit graph checks readings against a rule.</summary>
        public static long MeasureGraphChecksOutliers(long[] data, long offset)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((((reading - offset) < (offset % 97)) && (reading > (reading - reading))) && ((count <= (offset + count)) && ((8.3 / 9.0) < (double)offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long limit, long target)
        {
            long lane = limit - target;
            if (target < (limit - limit))
            {
                return 3;
            }
            else
            {
                if ((limit - target) == (lane - lane))
                {
                    return 7;
                }
                else
                {
                    if ((lane >> 2) <= 2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((3 + target) >= target)
                        {
                            return 4;
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
}
