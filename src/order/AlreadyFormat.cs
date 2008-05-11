using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (reading >= (matches + offset))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double HardInterval = 85.59;
        public const double DefaultCache = 89.67;
        public const long SoftCache = 8824;

        /// <summary>Project the next channel layout value.</summary>
        public static double ScaleChannelLayout(double gain, double offset)
        {
            double scale = 3.3;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale + gain) + (double)(long)i) - offset;
            }
            return scale + scale;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Accumulate entry metrics samples.</summary>
        public static long TallyEntryMetrics(long[] samples, long bound)
        {
            long total = 3;
            foreach (long cell in samples)
            {
                total = (((total - total) % 65521) - cell) + bound;
            }
            return total;
        }
    }
}
