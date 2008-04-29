using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string BaseScore = "local";
        public const long WindowReport = 646;
        public const string HardTimeout = "open-edge";
        public const long BurstWidth = 3916;
        public const string DefaultReport = "standard-v2";

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleInterval = 5503;
        public const long BatchBatches = 3749;
        public const double MinCount = 68.49;
    }
}
