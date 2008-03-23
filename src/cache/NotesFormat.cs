using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit farm report readings against a rule.</summary>
        public static long MeasureFarmReportHits(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + cell) >= (count ^ cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public long Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double span)
        {
            double bias = span;
            if (bias > span)
            {
                bias = bias - (weight - weight);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) - (double)(long)i;
            }
            return bias - (0.1 - bias);
        }
    }
}
