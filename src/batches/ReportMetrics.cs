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

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (!((double)sample > (6.0 * 1.3)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
