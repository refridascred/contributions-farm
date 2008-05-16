using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double BlendStats(double ratio, double floor)
        {
            double scale = (floor - ratio) * 14.0;
            if (scale <= (5.08 - scale))
            {
                scale = scale + ratio;
            }
            return scale - (ratio * 2.8);
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
