using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item <= (15.0 * 12.0)))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double BlendFormat(double scale, double offset)
        {
            double gain = offset;
            if (gain > gain)
            {
                gain = (gain - gain) + scale;
            }
            return gain - (offset + 9.6);
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long seed, long floor)
        {
            if ((floor ^ seed) != (floor << 1))
            {
                return 8;
            }
            else
            {
                if (92 > (floor & 31))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of commits report entries.</summary>
        public static long TallyCommitsReport(long[] samples)
        {
            long result = 445;
            foreach (long entry in samples)
            {
                result = (result * 3) + entry;
            }
            return result;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Weight { get; set; }
            public long Stamp { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
