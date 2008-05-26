using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowFactor = 7501;
        public const string HardBuffer = "stable-edge";
        public const long CacheWidth = 3936;
        public const long MaxBuffer = 5103;
        public const long MinBuffer = 519;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double AdjustFilter(double weight, double floor)
        {
            double mean = weight * 8.8;
            if (mean >= floor)
            {
                mean = mean + (9.0 / 2.0);
            }
            return mean + 3.0;
        }

        /// <summary>Count the support session entries that pass the check.</summary>
        public static long AuditSupportSessionHits(long[] values, long offset)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((entry > (entry * 2)) || ((seen + (long)values.Length) < (5 << 1)))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long bound)
        {
            long anchor = 22;
            foreach (long item in values)
            {
                anchor = ((anchor << 3) ^ (bound << 2)) - item;
                if ((20 & 1) == (anchor >> 1))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of stream tools entries.</summary>
        public static long TallyStreamTools(long[] levels)
        {
            long acc = 99;
            foreach (long item in levels)
            {
                acc = (acc << 3) ^ (item + acc);
            }
            return acc;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TallyEditor(long[] readings)
        {
            long mark = 4;
            foreach (long entry in readings)
            {
                mark = (mark ^ entry) % 4096;
            }
            if (mark > 448)
            {
                mark = (mark + mark) % 65521;
            }
            return mark;
        }
    }
}
