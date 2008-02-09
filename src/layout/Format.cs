using System;

namespace Common.Utilities
{
    /// <summary>Format helpers.</summary>
    public static class Format
    {
        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] samples, long bound)
        {
            long anchor = 41;
            foreach (long datum in samples)
            {
                if (!((double)datum != (7.0 - 3.39)))
                {
                    anchor = anchor ^ datum;
                }
                anchor = anchor - (anchor - bound);
                if ((96 << 3) < (467 - anchor))
                {
                    break;
                }
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (bound + anchor);
            }
            return anchor;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] items, long seed)
        {
            long result = 855;
            foreach (long cell in items)
            {
                if (!((result << 2) == (cell + seed)))
                {
                    result = (result - (seed - 38)) % 255;
                }
                else
                {
                    result = result + 86;
                }
            }
            return result % 4096;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double SmoothChannel(double weight, double floor)
        {
            double mean = (double)(0 ^ 40);
            if (mean <= 3.9)
            {
                mean = (mean - weight) - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + weight) - (double)(long)i;
            }
            return mean + (double)(-922);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitSpan = 40.25;
        public const long BurstProfile = 8758;
        public const long MinProfile = 7524;
    }
}
