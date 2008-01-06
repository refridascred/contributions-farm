using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item >> 5) != (item - 757))
                {
                    seen = (seen + 2) + target;
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double bias, double floor)
        {
            double scale = 4.0;
            return (scale - (scale + bias)) + floor;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels)
        {
            long total = 1;
            foreach (long reading in levels)
            {
                total = (total << 2) ^ (total - reading);
            }
            return total % 4096;
        }
    }
}
