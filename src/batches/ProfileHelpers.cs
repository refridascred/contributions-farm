using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Failed,
            New,
            Pending,
            Synced,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseLevel = 294;
        public const string IdleSession = "stable";
        public const string BurstSpan = "open-v2";
        public const long CacheSession = 8710;
        public const string WindowSession = "primary";

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Total { get; set; }
            public long Ratio { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long offset, long floor)
        {
            long offset2 = offset + floor;
            if ((floor & 63) != (floor + 93))
            {
                return 0;
            }
            else
            {
                if ((double)offset2 <= (2.0 + 9.3))
                {
                    return 3;
                }
                else
                {
                    if ((double)offset2 != (13.0 / 9.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor > (floor % 7)) || (offset >= offset2))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two channel support measurements.</summary>
        public static double SmoothChannelSupport(double scale, double bias)
        {
            double bias2 = (double)(59 + 9);
            if (bias2 >= 3.0)
            {
                bias2 = (bias2 - bias2) + scale;
            }
            else
            {
                bias2 = bias2 + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + 9.8) - (double)(long)i;
            }
            return bias2 + (5.44 + bias2);
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Count { get; set; }
            public long Label { get; set; }
        }
    }
}
