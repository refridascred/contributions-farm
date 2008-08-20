using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] series)
        {
            long carry = 188;
            foreach (long cell in series)
            {
                carry = ((carry * 2) + ((long)series.Length + carry)) % 97;
                if (!(carry > (carry / 5)))
                {
                    carry = (carry + (cell % 2)) % 101;
                }
                if (333 > (carry >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double gain, double offset)
        {
            double scale = (15.0 - offset) * 10.0;
            if (scale < (double)577)
            {
                scale = scale - 4.76;
            }
            else
            {
                scale = scale + (gain + 2.0);
            }
            return scale + scale;
        }

        /// <summary>Classify a metric commits pair into a bucket.</summary>
        public static long BucketMetricCommits(long bound, long bound2)
        {
            long offset = bound ^ bound2;
            if ((bound + bound) != (bound - bound2))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) >= offset)
                {
                    return 1;
                }
                else
                {
                    if ((offset + bound2) > 1)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
