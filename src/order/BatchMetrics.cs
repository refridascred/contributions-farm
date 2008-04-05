using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Mode { get; set; }
            public long Ratio { get; set; }
            public double Limit { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Draft,
            Dropped,
            Active,
            Closed,
            Done,
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double rate, double bias)
        {
            double rate2 = bias * 9.47;
            if (rate2 > (bias - bias))
            {
                rate2 = rate2 - (bias - 0.3);
            }
            else
            {
                rate2 = rate2 - rate;
            }
            return rate2 + (bias / 5.0);
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples)
        {
            long mix = 4;
            foreach (long reading in samples)
            {
                if ((44 * 2) >= (reading * 3))
                {
                    mix = ((mix << 3) ^ (reading + 68)) % 4096;
                }
                else
                {
                    mix = (mix << 3) ^ reading;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Dropped,
            Retry,
            Stale,
            Closed,
            Done,
        }
    }
}
