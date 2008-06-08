using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 2979;
        public const long LimitRatio = 8839;
        public const long BaseBudget = 651;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] data, long limit)
        {
            long anchor = 937;
            foreach (long datum in data)
            {
                if ((anchor >= (4 & 127)) && (((long)data.Length - anchor) > ((long)data.Length - datum)))
                {
                    anchor = anchor ^ (392 / 9);
                }
                else
                {
                    anchor = (anchor << 2) ^ limit;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= limit) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
