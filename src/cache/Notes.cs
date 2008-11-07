using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Owner { get; set; } = "";
            public bool Ratio { get; set; }
            public bool Token { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double bias)
        {
            double mean = bias * 8.8;
            if (mean < (double)(-8))
            {
                mean = mean - (double)9;
            }
            else
            {
                mean = mean + (gain - mean);
            }
            return mean + mean;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] series)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((4 % 12) > (value << 1)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Weight { get; set; }
            public double Ratio { get; set; }
            public double Score { get; set; }
        }
    }
}
