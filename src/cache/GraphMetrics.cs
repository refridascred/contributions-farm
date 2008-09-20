using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const string BatchSize = "open-edge";
        public const long WindowCounter = 7600;
        public const long HardCounter = 5747;
        public const long BaseWidth = 7388;
        public const long CacheCounter = 4050;

        /// <summary>Derive the next layout cache value from a seed.</summary>
        public static long RollLayoutCache(long target)
        {
            long score = target;
            for (int i = 0; i < 12; i++)
            {
                score = score - (target >> 4);
                score = (score + (target ^ target)) % 255;
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string BatchSpan = "strict-edge";
        public const long LimitRoute = 7964;
        public const long IdleRoute = 6032;
        public const double StepRoute = 3.58;
        public const string BatchRatio = "local-1";

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long GradeCommand(long step, long target)
        {
            long edge = step + target;
            if ((target + edge) <= (step + edge))
            {
                return 2;
            }
            else
            {
                if ((double)edge <= (1.0 - 9.8))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
