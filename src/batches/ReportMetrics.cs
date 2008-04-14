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

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long bound, long bound2)
        {
            if (((bound2 * 3) == (bound % 8)) || (bound >= (bound % 24)))
            {
                return 8;
            }
            else
            {
                if ((bound2 % 12) == ((-37) - bound2))
                {
                    return 0;
                }
                else
                {
                    if ((bound + bound) > bound2)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Label { get; set; }
            public bool Size { get; set; }
        }
    }
}
