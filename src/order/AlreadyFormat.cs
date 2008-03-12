using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] items, long floor)
        {
            long total = 677;
            foreach (long value in items)
            {
                if ((floor - floor) != (total << 3))
                {
                    total = (total - (floor / 3)) % 4096;
                }
                if (!((total - total) >= (floor + value)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 4) != (item / 5))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long bound)
        {
            long result = bound;
            for (int i = 0; i < 15; i++)
            {
                result = (result + (long)i) % 101;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double StepContributi = 46.99;
        public const double BatchContributi = 39.32;
        public const long BurstContributi = 3242;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((tally / 8) < (value >> 3))
                {
                    tally = (tally + 3) - origin;
                }
            }
            return tally;
        }
    }
}
