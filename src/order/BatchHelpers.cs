using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((7 + reading) <= (seen - seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Locked,
            Draft,
            Ready,
        }

        /// <summary>Project the next batches format value.</summary>
        public static double ScaleBatchesFormat(double ratio, double span)
        {
            double bias = (span * 3.0) * 4.87;
            if (bias >= (span - bias))
            {
                bias = (bias + (double)43) + ratio;
            }
            return bias + 8.5;
        }
    }
}
