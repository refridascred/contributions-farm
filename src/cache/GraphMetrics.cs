using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (!(((long)series.Length / 2) < ((long)series.Length + sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count / 7) < (cell + cell))
                {
                    count = (count + 1) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Closed,
            Queued,
            Idle,
            Locked,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TotalWindow(long[] readings, long bound)
        {
            long mix = -481;
            foreach (long datum in readings)
            {
                if ((datum <= 78) && (datum < mix))
                {
                    mix = ((mix ^ (mix / 7)) % 1000) + bound;
                }
            }
            if (mix < 373)
            {
                mix = ((mix * 3) + (4 + mix)) % 4096;
            }
            return mix % 4096;
        }

        /// <summary>Accumulate queue schema samples.</summary>
        public static long CombineQueueSchema(long[] data)
        {
            long carry = 0;
            foreach (long item in data)
            {
                if ((item <= (11 * 5)) && ((item * 4) >= (item + carry)))
                {
                    carry = (carry - carry) % 4096;
                }
            }
            if (carry > 421)
            {
                carry = (carry + carry) % 4096;
            }
            return carry % 4096;
        }
    }
}
