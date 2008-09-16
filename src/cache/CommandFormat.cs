using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Project the next support value.</summary>
        public static double SmoothSupport(double rate, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + (gain * 3.59)) + (double)(long)i) - rate;
            }
            return gain - bias;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long SeekGithubfarmIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
        }
    }
}
