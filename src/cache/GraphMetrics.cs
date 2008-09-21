using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Roll a graph support counter forward.</summary>
        public static long RollGraphSupport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 15; i++)
            {
                result = (result * 2) + ((long)i % 60);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a metric snapshot.</summary>
        public sealed class MetricSnapshot
        {
            public long Level { get; set; }
            public long Region { get; set; }
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
