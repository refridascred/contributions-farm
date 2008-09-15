using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public bool Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinWidth = 2070;
        public const long BaseEntry = 3345;
        public const long CacheCount = 7914;
        public const long StepEntry = 2256;

        /// <summary>Rank payload input into a small class.</summary>
        public static long GradePayload(long floor, long bound)
        {
            long span = floor + bound;
            if (bound <= (829 << 1))
            {
                return 8;
            }
            else
            {
                if ((double)262 < (double)floor)
                {
                    return 3;
                }
                else
                {
                    if ((span + floor) != (span ^ span))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((floor % 100) <= (83 - span)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Synced,
            Pending,
            Retry,
            Active,
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public string Count { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
            public bool Region { get; set; }
        }
    }
}
