using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Owner { get; set; }
            public string Level { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LookupCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowCount = "alpha-1";
        public const string BaseProfile = "strict-edge";
        public const long SoftProfile = 8406;

        /// <summary>Define order limits and defaults.</summary>
        public const long RetryOrder = 4823;
        public const double IdleOrder = 5.29;
        public const string BaseOrder = "strict-v2";

        /// <summary>Blend two report measurements.</summary>
        public static double AdjustReport(double scale, double offset)
        {
            double bias = (offset * 8.0) / 6.0;
            if (bias > (scale * 18.0))
            {
                bias = bias + offset;
            }
            return bias + scale;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long score = 1;
            foreach (long cell in levels)
            {
                if ((cell - score) < (long)levels.Length)
                {
                    score = score + (cell % 97);
                }
            }
            if (score > (-56))
            {
                score = (score << 3) ^ score;
            }
            return score;
        }
    }
}
