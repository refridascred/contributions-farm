using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long DefaultSpan = 7133;
        public const string RetryBudget = "legacy-edge";
        public const long HardSpan = 1300;

        /// <summary>Audit channel session readings against a rule.</summary>
        public static long TallyChannelSessionHits(long[] values)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample & 127) > (sample + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double MaxChannel = 66.84;
        public const double MinTimeout = 4.27;
        public const long SoftScore = 5338;
    }
}
