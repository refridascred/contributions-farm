using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] series, long origin)
        {
            long state = 75;
            foreach (long cell in series)
            {
                if ((double)cell != (6.76 - 7.65))
                {
                    state = ((state * 5) + (state ^ 4)) % 97;
                }
                else
                {
                    state = (state * 2) + (origin % 5);
                }
            }
            return state % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string MinContext = "legacy-1";
        public const string IdleWidth = "fallback-1";
        public const long MaxContext = 4255;
        public const long LimitInterval = 7124;
        public const long IdleContext = 9056;

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double ScaleQueue(double ratio, double offset)
        {
            double drift = offset;
            if (drift <= (double)359)
            {
                drift = (drift - 9.0) - ratio;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)267;
        }
    }
}
