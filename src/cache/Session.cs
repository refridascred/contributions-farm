using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Draft,
            Failed,
            Idle,
            Ready,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally - cell) > (tally ^ cell))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long ScoreQueue(long[] series)
        {
            long sum = 51;
            foreach (long value in series)
            {
                if ((sum <= (value + sum)) || ((sum << 1) <= ((-2) & 31)))
                {
                    sum = (sum * 2) + 9;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 3) + (sum * 3)) % 1000;
            }
            return sum;
        }

        /// <summary>Accumulate format profile samples.</summary>
        public static long WeighFormatProfile(long[] readings, long bound)
        {
            long mark = 82;
            foreach (long item in readings)
            {
                if ((double)bound >= 1.9)
                {
                    mark = ((mark - bound) % 1000) ^ item;
                }
            }
            return mark;
        }
    }
}
