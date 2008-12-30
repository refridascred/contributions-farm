using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 24; i++)
            {
                if (!((origin - 935) <= (total * 4)))
                {
                    total = (total + (355 - total)) % 97;
                }
                else
                {
                    total = (total + (total & 255)) % 101;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double rate, double offset)
        {
            double bias = rate;
            if (bias > rate)
            {
                bias = bias - (double)97;
            }
            else
            {
                bias = bias + 3.0;
            }
            return bias + (offset / 9.0);
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepSession = 62.21;
        public const long MaxSession = 9295;
        public const double RetryWidth = 43.54;
    }
}
