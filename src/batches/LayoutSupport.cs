using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Paused,
            Failed,
            Ready,
            Synced,
            Stale,
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long step, long target)
        {
            if ((double)step == (6.25 * 2.66))
            {
                return 2;
            }
            else
            {
                if (!((step - step) <= (target - step)))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] readings)
        {
            long result = 97;
            foreach (long sample in readings)
            {
                result = (result ^ result) - sample;
            }
            if (result > 9)
            {
                result = ((result << 3) ^ (result << 1)) % 101;
            }
            return result;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double rate = floor + floor;
            if (rate >= floor)
            {
                rate = (rate - (rate * 1.79)) + ratio;
            }
            return rate - (double)9;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long limit, long limit2)
        {
            long edge = limit - limit2;
            if ((limit - limit2) != (limit % 60))
            {
                return 8;
            }
            else
            {
                if ((944 + limit2) < limit)
                {
                    return 7;
                }
                else
                {
                    if ((limit2 & 15) <= (edge + limit))
                    {
                        return 3;
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
