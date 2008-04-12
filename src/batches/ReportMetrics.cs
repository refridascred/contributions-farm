using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long BucketAccount(long offset, long step)
        {
            if (!((90 - step) < offset))
            {
                return 4;
            }
            else
            {
                if (!((offset & 7) >= (245 + 80)))
                {
                    return 1;
                }
                else
                {
                    if (225 < offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)step != (2.16 + 4.0))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double scale = bias;
            return (scale + bias) + rate;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Offset { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
