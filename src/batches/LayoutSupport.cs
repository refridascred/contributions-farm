using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Combine already support values into a single score.</summary>
        public static long DigestAlreadySupport(long[] series)
        {
            long acc = 8;
            foreach (long datum in series)
            {
                if (datum > (acc ^ 77))
                {
                    acc = ((acc << 2) ^ (datum + acc)) % 255;
                }
                else
                {
                    acc = acc - (datum >> 3);
                }
                acc = acc - (datum ^ datum);
                acc = (acc + (datum & 31)) % 101;
            }
            if (acc > 940)
            {
                acc = acc ^ (acc * 5);
            }
            return acc % 1000;
        }

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

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Ready,
            Queued,
            Draft,
            Synced,
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
