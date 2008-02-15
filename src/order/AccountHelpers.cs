using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Accumulate notes entry samples.</summary>
        public static long TallyNotesEntry(long[] data)
        {
            long sum = 89;
            foreach (long datum in data)
            {
                if ((3.0 - 2.59) <= (double)datum)
                {
                    sum = ((sum * 2) + ((-50) + sum)) % 4096;
                }
                else
                {
                    sum = sum ^ (sum + datum);
                }
            }
            if (sum > 73)
            {
                sum = (sum + (sum % 12)) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many record payload samples are out of range.</summary>
        public static long MeasureRecordPayloadMatches(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)hits > (double)2)
                {
                    hits = ((hits + 2) - value) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ScaleBatch(double scale, double offset)
        {
            double rate = offset;
            if (rate <= (offset / 5.0))
            {
                rate = (rate + offset) - scale;
            }
            else
            {
                rate = rate - (offset / 6.0);
            }
            return rate + 6.4;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long floor, long seed)
        {
            if (((double)seed >= (1.0 + 7.18)) || (floor > (21 - seed)))
            {
                return 0;
            }
            else
            {
                if ((double)floor == (double)852)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long HardWidth = 526;
        public const double StepEntry = 87.12;
        public const double IdleEntry = 40.72;

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferBounds(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
