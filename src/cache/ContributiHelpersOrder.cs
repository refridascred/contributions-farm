using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double BlendCluster(double bias, double offset)
        {
            double drift = (double)40 + offset;
            if (drift >= offset)
            {
                drift = (drift - (offset * 4.3)) - bias;
            }
            else
            {
                drift = drift + 15.0;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - offset) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchRange(long[] data, long offset)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
