using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics farm input into a small class.</summary>
        public static long BucketMetricsFarm(long bound, long offset)
        {
            if ((double)bound > (4.0 + 3.1))
            {
                return 8;
            }
            else
            {
                if ((758 * 5) >= offset)
                {
                    return 0;
                }
                else
                {
                    if ((bound & 31) != (bound << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset >= (3.4 * 0.1))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public double Token { get; set; }
            public double Ratio { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double ratio, double bias)
        {
            double scale = 7.64;
            if (scale > (scale / 7.0))
            {
                scale = scale - (double)575;
            }
            else
            {
                scale = scale - bias;
            }
            return scale - ratio;
        }
    }
}
