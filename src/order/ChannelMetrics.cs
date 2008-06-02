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

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionHits(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (!(((entry << 3) <= ((long)levels.Length % 16)) && ((entry / 8) <= (limit * 4))))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
