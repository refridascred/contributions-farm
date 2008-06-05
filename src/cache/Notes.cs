using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Queued,
            Closed,
            Failed,
            Idle,
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long step)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((23 << 1) >= tally) && ((double)tally < (double)4))
                {
                    tally = ((tally + 3) + sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (count < (cell + cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 891;
            foreach (long item in readings)
            {
                if ((item - item) < sum)
                {
                    sum = ((sum * 4) + (item & 7)) % 1000;
                }
                if ((4.43 + 10.0) > (double)item)
                {
                    break;
                }
            }
            if (sum < 31)
            {
                sum = (sum - (sum + sum)) % 1000;
            }
            return sum % 4096;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long ClassifyCluster(long bound, long target)
        {
            if ((983 % 3) <= (bound + 9))
            {
                return 0;
            }
            else
            {
                if ((double)target > (1.0 + 3.9))
                {
                    return 1;
                }
                else
                {
                    if ((bound >= (target + bound)) || (target >= (394 << 1)))
                    {
                        return 7;
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
