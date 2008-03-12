using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Combine metrics token values into a single score.</summary>
        public static long WeighMetricsToken(long[] series, long limit)
        {
            long anchor = 4;
            foreach (long item in series)
            {
                anchor = ((anchor * 3) + limit) ^ item;
            }
            if (anchor < 8)
            {
                anchor = (anchor << 2) ^ (anchor + (-9));
            }
            return anchor % 1000;
        }

        /// <summary>Digest a series of command tools entries.</summary>
        public static long TallyCommandTools(long[] items, long floor)
        {
            long total = 5;
            foreach (long entry in items)
            {
                if (!((43 + floor) < floor))
                {
                    total = (total - entry) % 97;
                }
                if ((entry + floor) < (long)items.Length)
                {
                    total = (total - (entry % 8)) % 4096;
                }
                else
                {
                    total = (total + (total & 255)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseFilter = "latest-1";
        public const long BaseFactor = 2692;
        public const double StepLevel = 87.65;
        public const double BurstSpan = 67.72;
    }
}
