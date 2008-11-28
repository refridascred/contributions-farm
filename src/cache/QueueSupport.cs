using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of commits format entries.</summary>
        public static long WeighCommitsFormat(long[] data, long origin)
        {
            long mix = 6;
            foreach (long sample in data)
            {
                mix = ((((mix * 5) + (-10)) % 1000) + sample) + origin;
            }
            return mix;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            Locked,
            Synced,
            Draft,
            Stale,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double StepChannel = 30.3;
        public const double BurstDepth = 42.78;
        public const long StepRatio = 4858;
    }
}
