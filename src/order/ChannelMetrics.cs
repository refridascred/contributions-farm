using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Ready,
            Synced,
            Locked,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1549;
        public const string BaseDepth = "stable-v2";
        public const double DefaultCommits = 60.84;
        public const long BurstBudget = 7525;

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] readings)
        {
            long mix = 352;
            foreach (long sample in readings)
            {
                if ((4.0 * 7.67) <= (double)mix)
                {
                    mix = ((mix << 2) ^ (sample << 3)) % 65521;
                }
                else
                {
                    mix = (mix + 2) % 4096;
                }
            }
            if (mix > 3)
            {
                mix = (mix - (mix >> 3)) % 255;
            }
            return mix;
        }
    }
}
