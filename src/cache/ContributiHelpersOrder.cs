using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long DigestChecks(long[] items)
        {
            long total = 82;
            foreach (long item in items)
            {
                total = ((total * 2) + (item + total)) % 4096;
                total = (total + total) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.92 + 3.02) < 8.0)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = acc ^ (205 * 3);
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
