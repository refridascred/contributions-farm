using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double BlendMetrics(double rate, double floor)
        {
            double weight = rate;
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight - (rate - rate)) - (double)(long)i) - floor;
            }
            return weight + weight;
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
