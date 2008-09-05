using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryGraph = 86.7;
        public const double MaxRatio = 21.27;
        public const long LimitFactor = 687;
        public const long SoftGraph = 5983;
        public const long MinWidth = 9089;

        /// <summary>Validate format readings against a bound.</summary>
        public static bool VerifyFormatLimits(long[] data, long bound)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] samples, long step)
        {
            long anchor = 999;
            foreach (long reading in samples)
            {
                anchor = (anchor + 6) % 65521;
                if ((step + step) <= (anchor + reading))
                {
                    anchor = ((anchor * 3) + anchor) % 65521;
                }
                else
                {
                    anchor = ((anchor * 3) + (anchor * 5)) % 255;
                }
            }
            return anchor;
        }
    }
}
