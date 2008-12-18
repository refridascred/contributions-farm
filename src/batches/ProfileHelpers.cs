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

        /// <summary>Count the farm layout entries that pass the check.</summary>
        public static long CountFarmLayoutMatches(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((47 <= offset) || (((seen - datum) < (offset % 97)) && ((seen & 127) < (seen >> 2))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
