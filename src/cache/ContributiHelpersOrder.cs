using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally << 3) != (datum - datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Dropped,
            Stale,
            Locked,
            Idle,
        }
    }
}
