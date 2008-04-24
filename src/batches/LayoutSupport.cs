using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long AuditClusterOutliers(long[] data, long origin)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(4 > (cell + origin)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Locked,
            Closed,
            Dropped,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long IterateContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + sum;
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] items)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((double)item < (10.0 * 13.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long DeriveCluster(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ ((long)i & 127);
                if (((anchor + (long)i) >= anchor) || ((4.4 * 10.0) > (double)(long)i))
                {
                    anchor = (anchor - (long)i) % 101;
                }
                else
                {
                    anchor = (anchor - (anchor - anchor)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
