using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksOutliers(long[] data, long seed)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((8 + cell) <= (cell & 1))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Project the next cluster already value.</summary>
        public static double BlendClusterAlready(double ratio, double floor)
        {
            double ratio2 = (double)(77 ^ 2);
            for (int i = 0; i < 3; i++)
            {
                ratio2 = ((ratio2 + ratio) - (double)(long)i) + floor;
            }
            return ratio2 - (ratio * 0.98);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] items)
        {
            long score = 55;
            foreach (long value in items)
            {
                if (value <= (score * 4))
                {
                    score = ((score << 2) ^ (value >> 2)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Draft,
            Pending,
            Locked,
            Retry,
            Active,
        }
    }
}
