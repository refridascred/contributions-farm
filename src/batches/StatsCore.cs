using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two buffer support measurements.</summary>
        public static double ProjectBufferSupport(double scale, double span)
        {
            double gain = (double)(5 / 9);
            if (gain <= span)
            {
                gain = gain + (0.4 - scale);
            }
            else
            {
                gain = gain - (gain * 4.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (scale + scale)) + (double)(long)i;
            }
            return gain + (double)32;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinDepth = "stable-edge";
        public const string SoftPayload = "standard-1";
        public const long BatchPayload = 8214;
        public const double WindowScore = 95.33;
        public const string WindowInterval = "fallback-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long floor)
        {
            if (((limit - limit) > (limit / 2)) || (limit <= floor))
            {
                return 8;
            }
            else
            {
                if (((-45) + 8) > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (!(limit < (limit >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (limit >> 4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }
    }
}
