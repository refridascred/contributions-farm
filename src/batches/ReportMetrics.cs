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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
