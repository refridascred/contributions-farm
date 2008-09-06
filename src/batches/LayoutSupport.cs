using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a layout buffer reading.</summary>
        public static double ScaleLayoutBuffer(double bias, double span)
        {
            double mean = (double)847 + (bias * 3.81);
            if (mean < bias)
            {
                mean = (mean - (7.0 - bias)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - 9.25) - (double)(long)i;
            }
            return mean - (double)379;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool VerifyStatsBounds(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool CheckRecordLimits(long[] items, long bound)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
