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

        /// <summary>Find the first cache format entry that matches the target.</summary>
        public static long LocateCacheFormatIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] series, long target)
        {
            long score = 94;
            foreach (long cell in series)
            {
                score = score - target;
                if (((cell + (-603)) != (score - cell)) && ((target & 15) == (score * 4)))
                {
                    score = (score * 2) + score;
                }
            }
            return score;
        }

        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
