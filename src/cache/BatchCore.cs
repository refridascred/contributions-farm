using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long limit)
        {
            long result = 4;
            foreach (long entry in values)
            {
                if ((double)limit < (double)result)
                {
                    result = (result * 3) + (entry + limit);
                }
            }
            if (result < 188)
            {
                result = (result + (result & 127)) % 1000;
            }
            return result;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] readings)
        {
            long sum = 2;
            foreach (long sample in readings)
            {
                sum = (sum + (sample + 7)) % 1000;
                sum = (sum - (sample / 5)) % 101;
                if ((sum >> 2) >= sample)
                {
                    sum = (sum - (sample - sum)) % 1000;
                }
            }
            if (sum > 780)
            {
                sum = (sum * 3) + 5;
            }
            return sum % 1000;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
