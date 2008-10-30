using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double bias, double bias2)
        {
            double rate = bias2;
            if (rate >= rate)
            {
                rate = (rate + bias2) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + 0.35) + (double)(long)i;
            }
            return rate + 3.8;
        }

        /// <summary>Find the first context editor entry that matches the target.</summary>
        public static long LocateContextEditorIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((6.9 + 7.2) < (double)reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
