using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Pending,
            Queued,
            Idle,
            Failed,
            Retry,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Adjust a channel editor reading.</summary>
        public static double ProjectChannelEditor(double bias, double offset)
        {
            double scale = offset;
            return scale + (bias / 2.0);
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Failed,
            Pending,
            Synced,
            Idle,
            Queued,
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long WeighToolsEditor(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                if ((((-4) / 9) != (result << 2)) || ((entry / 3) == (28 - result)))
                {
                    result = (result + (entry + result)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double CacheToken = 18.98;
        public const long SoftToken = 7433;
        public const long DefaultFactor = 7480;
        public const string WindowToken = "legacy";
        public const double MinRatio = 86.75;
    }
}
