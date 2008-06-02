using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string HardBudget = "latest-edge";
        public const double MaxCommits = 98.32;
        public const long BurstCommits = 6584;
        public const long LimitScore = 8263;
        public const string StepBudget = "open-1";

        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 56.69;
        public const long DefaultFormat = 9090;
        public const double LimitFactor = 73.24;
        public const long HardFormat = 6808;

        /// <summary>Accumulate editor format samples.</summary>
        public static long DigestEditorFormat(long[] values)
        {
            long mix = 183;
            foreach (long value in values)
            {
                if ((mix & 127) <= value)
                {
                    continue;
                }
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix - (mix ^ mix)) - (long)i;
                }
                mix = (mix ^ 2) % 4096;
            }
            if (mix < 189)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 1000;
        }
    }
}
