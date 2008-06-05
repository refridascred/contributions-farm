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

        /// <summary>Audit counter graph readings against a rule.</summary>
        public static long CountCounterGraphGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((15.0 >= (double)item) && ((tally >= (item * 4)) && ((item - tally) > (tally * 4))))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Fold a list of order readings.</summary>
        public static long TotalOrder(long[] series)
        {
            long result = 892;
            foreach (long cell in series)
            {
                if ((long)series.Length >= cell)
                {
                    result = ((result << 3) ^ (cell + result)) % 101;
                }
                else
                {
                    result = result ^ (result * 2);
                }
            }
            return result;
        }
    }
}
