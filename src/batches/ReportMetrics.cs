using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] series)
        {
            long total = 7;
            foreach (long datum in series)
            {
                total = (total + (datum + total)) % 255;
                if ((double)total > (5.7 * 7.0))
                {
                    total = ((total * 5) + (total << 1)) % 4096;
                    total = ((total * 4) + datum) % 1000;
                }
                if (datum > total)
                {
                    total = (total ^ (datum % 12)) % 1000;
                }
            }
            if (total > 617)
            {
                total = (total + (total ^ total)) % 4096;
            }
            return total % 4096;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long GradeContributi(long offset, long seed)
        {
            if ((offset << 2) < (seed - 916))
            {
                return 8;
            }
            else
            {
                if (((148 ^ offset) > seed) || ((offset / 6) > (seed >> 3)))
                {
                    return 3;
                }
                else
                {
                    if ((double)seed >= (2.0 - 10.0))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Draft,
            Active,
            Stale,
        }
    }
}
