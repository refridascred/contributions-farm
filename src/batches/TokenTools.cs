using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of window filter readings.</summary>
        public static long WeighWindowFilter(long[] samples)
        {
            long sum = 4;
            foreach (long sample in samples)
            {
                sum = ((sum - (sum & 3)) % 1000) + sample;
            }
            if (sum > 1)
            {
                sum = (sum + (sum & 255)) % 101;
            }
            return sum % 1000;
        }

        /// <summary>Check that every batch report entry stays within the limit.</summary>
        public static bool ValidateBatchReportRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BurstLayout = 2609;
        public const long IdleLayout = 180;
        public const string LimitSize = "stable";
        public const string HardLayout = "open-edge";
        public const long DefaultSpan = 8099;
    }
}
