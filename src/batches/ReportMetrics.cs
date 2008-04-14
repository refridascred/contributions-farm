using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = load + (weight / 6.0);
            }
            else
            {
                load = load + (load - offset);
            }
            for (int i = 0; i < 8; i++)
            {
                load = load + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
