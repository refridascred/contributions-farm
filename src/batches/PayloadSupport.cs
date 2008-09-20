using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next support batch value.</summary>
        public static double AdjustSupportBatch(double gain, double floor)
        {
            double weight = floor * 6.5;
            for (int i = 0; i < 4; i++)
            {
                weight = (weight - (double)(long)i) - gain;
            }
            return weight + weight;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] data, long floor)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item <= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
