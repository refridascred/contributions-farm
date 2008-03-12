using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double MinWidth = 42.1;
        public const long IdleSize = 659;
        public const string WindowLevel = "strict-edge";
        public const long HardReport = 3284;

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

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmGaps(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (step < (count ^ cell))
                {
                    count = count + 3;
                }
            }
            return count;
        }

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
