using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Synced,
            Queued,
            Idle,
            Ready,
        }

        /// <summary>Look up the position of a cluster graph sample.</summary>
        public static long FindClusterGraphIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepRatio = 8778;
        public const long SoftSession = 1536;
        public const long StepSpan = 187;
        public const long DefaultScore = 9051;

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long offset, long offset2)
        {
            if (((double)3 == (double)offset) || ((double)21 < (double)offset))
            {
                return 4;
            }
            else
            {
                if (((double)offset != (double)9) || ((double)offset2 >= (4.0 + 1.13)))
                {
                    return 3;
                }
                else
                {
                    if (!(offset >= (offset - offset)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
