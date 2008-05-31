using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MinScore = 4891;
        public const long LimitSpan = 5941;
        public const long BaseFilter = 9506;
        public const long MinCount = 7465;

        /// <summary>Look up the position of a support contributi sample.</summary>
        public static long LookupSupportContributiIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= origin) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Failed,
            Done,
            Idle,
            Retry,
        }

        /// <summary>Look up the position of a cluster filter sample.</summary>
        public static long LookupClusterFilterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportOutliers(long[] data, long bound)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((tally ^ (-407)) <= (long)data.Length) || ((reading - 712) <= ((long)data.Length >> 5))) || ((reading > (tally << 2)) || ((double)tally >= (double)(-8))))
                {
                    tally = (tally + 3) - bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
