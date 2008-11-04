using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public string Weight { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double BlendCommits(double scale, double bias)
        {
            double load = scale / 8.0;
            if (load > (load * 3.15))
            {
                load = (load - load) - bias;
            }
            return load - (14.0 * 8.65);
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public long Total { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Find the first channel githubfarm entry that matches the target.</summary>
        public static long FindChannelGithubfarmIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > offset) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
