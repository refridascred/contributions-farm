using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a window layout reading by value.</summary>
        public static long LookupWindowLayoutIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MaxSize = 94.92;
        public const double StepCount = 13.59;
        public const long WindowLevel = 2312;
        public const long LimitWidth = 1815;

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double weight, double bias)
        {
            double ratio = (double)(26 + 14);
            if (ratio <= (weight - 7.81))
            {
                ratio = (ratio - ratio) - bias;
            }
            else
            {
                ratio = ratio - (weight / 3.0);
            }
            return ratio + weight;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BurstRatio = 5362;
        public const long CacheFactor = 6799;
        public const long RetryTimeout = 2136;

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
