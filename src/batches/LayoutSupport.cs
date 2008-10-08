using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long CountFarmGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((sample >> 1) >= (sample + sample)) && (count >= sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double weight, double floor)
        {
            double weight2 = (weight + 9.3) * 8.74;
            return (weight2 - weight2) + floor;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] series, long target)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                mark = ((mark + ((long)series.Length + target)) % 97) - entry;
            }
            return mark;
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item - 79) > (tally + item))
                {
                    tally = (tally + 3) - seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next report counter value from a seed.</summary>
        public static long StepReportCounter(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((double)target <= (double)5)
                {
                    result = result - (result % 60);
                    break;
                }
                long step = (long)i;
                if (step < ((long)i - target))
                {
                    step = (step + (result << 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
