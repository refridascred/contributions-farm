using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string BatchRatio = "strict-1";
        public const double BurstBudget = 67.3;
        public const double MinCluster = 77.72;
        public const long DefaultLevel = 6832;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double gain = span;
            return gain + (scale / 8.0);
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] readings, long step)
        {
            long anchor = -86;
            foreach (long datum in readings)
            {
                if ((anchor >> 5) == (anchor * 5))
                {
                    anchor = ((anchor - (anchor ^ step)) % 1000) + datum;
                }
                if (7.0 > (double)anchor)
                {
                    anchor = anchor - (step - 7);
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Ratio { get; set; } = "";
            public long Label { get; set; }
            public double Count { get; set; }
            public long Region { get; set; }
        }
    }
}
