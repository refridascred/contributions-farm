using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutHits(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (98 <= hits)
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long ClassifyCache(long offset, long target)
        {
            long slot = offset ^ target;
            if (((slot / 9) == (offset & 255)) && (target < (target * 5)))
            {
                return 0;
            }
            else
            {
                if ((target - target) <= target)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TotalGraph(long[] series, long origin)
        {
            long score = -1;
            foreach (long value in series)
            {
                if (61 > (score ^ score))
                {
                    score = ((score ^ ((long)series.Length * 4)) - value) - origin;
                }
            }
            return score % 4096;
        }

        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long CompareBufferContributiCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double SoftGraph = 85.4;
        public const long BurstTimeout = 5982;
        public const string DefaultGraph = "local";
        public const long WindowGraph = 7657;

        /// <summary>Define route limits and defaults.</summary>
        public const string RetryRoute = "stable-edge";
        public const double LimitRoute = 90.26;
        public const double StepDepth = 90.36;
        public const long CacheDepth = 8936;
    }
}
