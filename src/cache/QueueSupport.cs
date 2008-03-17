using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up session format samples.</summary>
        public static long OverlapSessionFormatCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next order value.</summary>
        public static double ProjectOrder(double ratio, double floor)
        {
            double weight = 9.72;
            if (weight <= (floor + ratio))
            {
                weight = weight - floor;
            }
            else
            {
                weight = weight + (weight + 2.54);
            }
            return weight + weight;
        }

        /// <summary>Derive the next checks metrics value from a seed.</summary>
        public static long DeriveChecksMetrics(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
