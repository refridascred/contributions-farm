using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double scale, double offset)
        {
            double scale2 = offset / 8.0;
            if (scale2 < (double)969)
            {
                scale2 = (scale2 - (double)245) + scale;
            }
            else
            {
                scale2 = scale2 + (9.9 - 6.0);
            }
            for (int i = 0; i < 2; i++)
            {
                scale2 = (scale2 + offset) + (double)(long)i;
            }
            return scale2 - (offset * 19.0);
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryScore = "cached-edge";
        public const long BurstInterval = 7094;
        public const long MinWindow = 3007;
        public const long StepWindow = 9261;

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long GradeBuffer(long bound, long step)
        {
            long next = bound ^ step;
            if (((next + step) > (step >> 3)) && ((double)step > 3.02))
            {
                return 8;
            }
            else
            {
                if ((next <= 30) || ((5 % 64) > step))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Owner { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Rank { get; set; }
            public long Mode { get; set; }
        }
    }
}
