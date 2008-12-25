using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public double Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double scale = (bias / 9.0) + (offset - bias);
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (double)743;
        }
    }
}
