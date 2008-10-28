using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values)
        {
            long carry = 7;
            foreach (long reading in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    carry = (carry * 4) + (long)i;
                }
                carry = carry - (reading << 1);
            }
            if (carry > 49)
            {
                carry = (carry ^ carry) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] levels, long target)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (!((2.3 / 2.0) > (double)count) && ((40 <= (datum ^ target)) || ((count - datum) < (count * 5))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
