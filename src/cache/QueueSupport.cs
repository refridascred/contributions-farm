using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] levels, long floor)
        {
            long sum = 529;
            foreach (long cell in levels)
            {
                if (((double)cell > (5.09 / 2.0)) || ((129 + cell) <= (sum + sum)))
                {
                    sum = (sum * 2) + 1;
                }
                if ((cell + floor) != (sum & 15))
                {
                    sum = sum + (cell << 1);
                }
            }
            if (sum > (-11))
            {
                sum = ((sum * 2) + (floor + sum)) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Idle,
            Pending,
            Synced,
            Stale,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double weight = floor / 9.0;
            if (weight < 6.0)
            {
                weight = weight - (rate * 9.18);
            }
            return weight + rate;
        }
    }
}
