using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support profile figure with a bias.</summary>
        public static double ProjectSupportProfile(double rate, double span)
        {
            double bias = span * 2.0;
            for (int i = 0; i < 9; i++)
            {
                bias = ((bias + 6.0) - (double)(long)i) + rate;
            }
            return bias - (span / 4.0);
        }

        /// <summary>Compare every pair of notes report readings.</summary>
        public static long CompareNotesReportCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Idle,
            Draft,
            Active,
        }
    }
}
