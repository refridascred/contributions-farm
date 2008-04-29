using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next filter metric value from a seed.</summary>
        public static long DeriveFilterMetric(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc << 2) ^ (8 % 64)) % 97;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((matches ^ sample) < (sample >> 1)) && ((sample >> 2) == (sample - 247))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
            public double Flag { get; set; }
            public bool Offset { get; set; }
        }
    }
}
