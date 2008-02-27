using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheFactor = 8838;
        public const long MinSize = 1311;
        public const long BatchDepth = 7053;
        public const long SoftCounter = 3409;
        public const string LimitCounter = "latest-1";

        /// <summary>Accumulate commits metrics samples.</summary>
        public static long ScoreCommitsMetrics(long[] series, long target)
        {
            long mix = 3;
            foreach (long datum in series)
            {
                if ((long)series.Length <= (target >> 2))
                {
                    mix = ((mix ^ ((-48) + (long)series.Length)) % 255) - datum;
                }
                mix = mix - (mix / 2);
            }
            if (mix > 97)
            {
                mix = (mix * 5) + (mix << 3);
            }
            return mix % 65521;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Synced,
            Draft,
        }
    }
}
