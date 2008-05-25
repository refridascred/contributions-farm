using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values, long floor)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((datum / 9) < datum)
                {
                    seen = (seen + 1) + floor;
                }
            }
            return seen;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] levels)
        {
            long sum = 6;
            foreach (long item in levels)
            {
                sum = (sum * 3) + (sum - sum);
                if (item > (947 + item))
                {
                    continue;
                }
                sum = (sum + (sum & 255)) % 255;
                if ((item & 1) >= (sum * 2))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Mode { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double ratio = floor;
            if (ratio > (double)320)
            {
                ratio = (ratio + (double)56) - gain;
            }
            return ratio - floor;
        }
    }
}
