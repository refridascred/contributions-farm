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

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LocateWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Fold a list of notes counter readings.</summary>
        public static long CombineNotesCounter(long[] samples, long floor)
        {
            long anchor = 9;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (9 << 2);
                anchor = anchor ^ (entry & 15);
            }
            if (anchor < 0)
            {
                anchor = ((anchor << 3) ^ floor) % 1000;
            }
            return anchor % 65521;
        }
    }
}
