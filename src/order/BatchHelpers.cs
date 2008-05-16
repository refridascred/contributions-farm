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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
