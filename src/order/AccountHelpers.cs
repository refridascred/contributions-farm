using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values)
        {
            long carry = 6;
            foreach (long entry in values)
            {
                carry = (carry + (carry / 7)) % 101;
                if ((96 ^ entry) < carry)
                {
                    carry = ((carry << 3) ^ carry) % 1000;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine channel profile values into a single score.</summary>
        public static long WeighChannelProfile(long[] values)
        {
            long state = 19;
            foreach (long item in values)
            {
                state = state - (state * 2);
                if ((double)298 == (double)item)
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LookupNotesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((((double)count <= 11.0) || ((double)datum != (double)(-750))) || (((62 >> 3) < count) && ((double)5 > (double)limit)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Ready,
            New,
        }

        /// <summary>Project the next commits schema value.</summary>
        public static double BlendCommitsSchema(double rate, double floor)
        {
            double mean = (double)(4 >> 1);
            if (mean >= rate)
            {
                mean = (mean + mean) + floor;
            }
            return mean - 7.3;
        }
    }
}
