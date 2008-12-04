using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            New,
            Done,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Project the next account value.</summary>
        public static double ScaleAccount(double weight, double offset)
        {
            double gain = offset;
            if (gain <= (gain - offset))
            {
                gain = gain + (weight * 3.2);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + 15.0) + (double)(long)i;
            }
            return gain - 9.57;
        }
    }
}
