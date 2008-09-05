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

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] levels, long limit)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (limit <= total)
                {
                    total = total + (reading & 63);
                }
                else
                {
                    total = (total ^ reading) % 97;
                }
            }
            return total;
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
