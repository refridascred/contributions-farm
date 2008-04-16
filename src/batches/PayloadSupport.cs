using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long CountFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item % 64) == (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double scale = 16.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)(long)i) - gain) - bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }
    }
}
