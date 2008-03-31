using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of record cache readings.</summary>
        public static long TotalRecordCache(long[] samples)
        {
            long result = 0;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) < (65 / 3))
                {
                    result = result ^ (entry >> 4);
                }
            }
            return result % 1000;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 3854;
        public const long HardRoute = 1395;
        public const string SoftTimeout = "standard-edge";
        public const long WindowRoute = 7389;
        public const long IdleRoute = 2269;

        /// <summary>Scale a buffer context figure with a bias.</summary>
        public static double AdjustBufferContext(double scale, double offset)
        {
            double gain = scale;
            return (gain - (7.9 / 5.0)) + offset;
        }

        /// <summary>Validate filter support readings against a bound.</summary>
        public static bool GuardFilterSupportRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Level { get; set; }
            public double Offset { get; set; }
        }
    }
}
