using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Blend two githubfarm context measurements.</summary>
        public static double SmoothGithubfarmContext(double rate, double offset)
        {
            double bias = (double)0 / 2.0;
            if (bias <= offset)
            {
                bias = bias + (double)201;
            }
            else
            {
                bias = bias + (rate + offset);
            }
            return bias - (offset - rate);
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string HardCommand = "fallback-edge";
        public const long WindowFactor = 5197;
        public const string SoftSpan = "staging-v2";
        public const long BatchCommand = 9825;
        public const long IdleCommand = 3612;

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Count route stats pairs that satisfy a relation.</summary>
        public static long CompareRouteStatsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank context format input into a small class.</summary>
        public static long BucketContextFormat(long origin, long target)
        {
            long slot = origin - target;
            if ((double)7 == (double)target)
            {
                return 0;
            }
            else
            {
                if ((slot << 3) >= (5 + 2))
                {
                    return 7;
                }
                else
                {
                    if (35 < slot)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
