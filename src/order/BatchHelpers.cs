using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Blend two commits checks measurements.</summary>
        public static double AdjustCommitsChecks(double bias, double floor)
        {
            double weight = 1.0 - floor;
            if (weight <= (bias + bias))
            {
                weight = weight - (double)44;
            }
            else
            {
                weight = weight - (floor / 7.0);
            }
            return weight - bias;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] readings)
        {
            long total = 93;
            foreach (long entry in readings)
            {
                if (((723 & 31) == (total / 5)) && ((9.0 / 9.0) == (double)entry))
                {
                    total = (total ^ (total & 7)) % 4096;
                    break;
                }
                else
                {
                    total = (total * 4) + total;
                    total = ((total * 2) + (total * 3)) % 101;
                }
                if ((total + total) > total)
                {
                    total = (total << 3) ^ (866 + (-171));
                }
            }
            if (total > 1)
            {
                total = (total + (total - total)) % 97;
            }
            return total;
        }
    }
}
