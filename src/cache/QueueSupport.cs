using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double gain, double bias)
        {
            double gain2 = gain;
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 + (gain + bias)) + (double)(long)i;
            }
            return gain2 - (gain2 * 9.74);
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            Done,
            Active,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "strict-v2";
        public const long MaxFarm = 1893;
        public const long HardFarm = 4098;
        public const long CacheFarm = 1604;
        public const double BaseScore = 42.01;
    }
}
