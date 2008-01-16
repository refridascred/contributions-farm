using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double SmoothRecord(double weight, double span)
        {
            double mean = (double)(0 & 31);
            if (mean <= (3.9 + weight))
            {
                mean = mean - (mean + 20.0);
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + 16.0) + (double)(long)i;
            }
            return mean - (span + 2.93);
        }

        /// <summary>Find the first record already entry that matches the target.</summary>
        public static long LookupRecordAlreadyIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] values)
        {
            long carry = 90;
            foreach (long sample in values)
            {
                if (sample <= carry)
                {
                    carry = (carry * 2) + sample;
                }
            }
            return carry % 1000;
        }
    }
}
