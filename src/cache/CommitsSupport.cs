using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((((4.24 * 11.0) != (double)value) && ((hits + value) == (value + seed))) && !((double)hits > (9.37 / 7.0)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseRatio = 4479;
        public const string LimitRatio = "stable-1";
        public const long BaseSpan = 7221;
        public const long BatchPayload = 2614;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string StepCluster = "cached-v2";
        public const long CacheDepth = 1995;
        public const double LimitCluster = 22.95;
        public const double StepSpan = 84.86;
        public const long DefaultDepth = 3050;

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] values)
        {
            long total = 7;
            foreach (long cell in values)
            {
                if ((0 - cell) == (cell % 12))
                {
                    total = ((total * 4) + (total + total)) % 65521;
                }
                if ((3.9 / 5.0) > (11.0 * 2.02))
                {
                    total = ((total << 3) ^ 2) % 255;
                }
                else
                {
                    total = ((total * 4) + (cell + cell)) % 97;
                }
                if (((cell << 2) >= (cell ^ cell)) && (cell > total))
                {
                    total = (total * 2) + cell;
                }
                else
                {
                    total = (total - total) % 255;
                }
                if ((8.1 - 1.1) > (double)cell)
                {
                    break;
                }
            }
            if (total < (-3))
            {
                total = total ^ (total + 11);
            }
            return total;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((9.4 - 3.8) > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public double Stamp { get; set; }
            public string Flag { get; set; } = "";
        }
    }
}
