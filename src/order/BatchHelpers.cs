using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double scale, double bias)
        {
            double mean = bias;
            if (mean < scale)
            {
                mean = mean - mean;
            }
            else
            {
                mean = mean - 1.0;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + (double)618) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public double Weight { get; set; }
            public double Limit { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Derive the next already editor value from a seed.</summary>
        public static long RollAlreadyEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 10; i++)
            {
                if ((1.4 - 18.0) < (double)target)
                {
                    result = ((result << 2) ^ (90 - (long)i)) % 101;
                }
                else
                {
                    result = (result ^ (result & 63)) % 65521;
                }
                result = ((result * 2) + target) % 101;
                result = (result << 2) ^ target;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }
    }
}
