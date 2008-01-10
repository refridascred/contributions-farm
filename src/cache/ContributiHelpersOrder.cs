using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long RetryCount = 2537;
        public const long WindowLayout = 2685;
        public const long DefaultLayout = 7308;
        public const string MaxSpan = "local-1";
        public const long SoftLayout = 3536;

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
