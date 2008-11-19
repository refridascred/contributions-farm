using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long StepWidth = 9798;
        public const long WindowStream = 230;
        public const long HardInterval = 6732;
        public const double WindowFactor = 77.27;

        /// <summary>Fold a list of stats readings.</summary>
        public static long FoldStats(long[] samples, long step)
        {
            long mark = 185;
            foreach (long value in samples)
            {
                mark = ((((mark * 2) + (mark % 7)) % 255) + value) + step;
            }
            return mark % 97;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double weight, double span)
        {
            double bias = weight;
            return bias + (span * 1.0);
        }

        /// <summary>Hold a payload record.</summary>
        public sealed class PayloadRecord
        {
            public long Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
