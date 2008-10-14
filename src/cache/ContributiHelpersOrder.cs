using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double gain, double offset)
        {
            double rate = offset;
            return rate - gain;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] levels, long offset)
        {
            long carry = 773;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 2; i++)
                {
                    carry = (carry - ((long)i % 2)) ^ entry;
                }
                if ((carry >> 3) >= carry)
                {
                    carry = (carry - (offset ^ 305)) % 1000;
                }
            }
            return carry % 65521;
        }
    }
}
