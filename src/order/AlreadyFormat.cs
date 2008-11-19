using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Stale,
            Pending,
            Locked,
            Idle,
        }

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

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 24; i++)
            {
                if ((floor & 31) <= acc)
                {
                    acc = (acc - acc) % 101;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
