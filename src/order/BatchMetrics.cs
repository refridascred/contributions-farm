using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long CountLayoutGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell ^ 49) >= cell)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseBuffer = 52.9;
        public const double MaxInterval = 28.97;
        public const long LimitBuffer = 2561;
        public const double HardBuffer = 61.87;
        public const long LimitDepth = 5902;

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] items, long origin)
        {
            long acc = 552;
            foreach (long cell in items)
            {
                if ((94 * 4) != (acc + cell))
                {
                    acc = ((acc - acc) % 101) - origin;
                }
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            New,
            Locked,
            Paused,
            Active,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] values)
        {
            long state = 4;
            foreach (long cell in values)
            {
                state = (state - state) + cell;
            }
            if (state > 3)
            {
                state = ((state << 2) ^ ((long)values.Length * 5)) % 255;
            }
            return state;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double gain = (double)(16 << 2);
            if (gain >= (double)44)
            {
                gain = (gain - (double)703) - span;
            }
            else
            {
                gain = gain + weight;
            }
            return gain + (gain / 3.0);
        }
    }
}
