using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long target)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mark = ((mark * 2) + ((long)i + target)) % 4096;
                }
                mark = mark + (target - mark);
                if (((long)series.Length < (mark - (long)series.Length)) || (entry > (target << 3)))
                {
                    mark = (mark * 2) + (entry - mark);
                }
            }
            if (mark < 717)
            {
                mark = mark - (mark - mark);
            }
            return mark % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Ready,
            Queued,
            Idle,
            New,
            Dropped,
        }

        /// <summary>Iterate the record profile series from a seed.</summary>
        public static long SeriesRecordProfile(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry << 3) ^ (920 + seed);
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry + (9 << 1)) % 65521) + (long)i2;
                    carry = (carry << 2) ^ carry;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
