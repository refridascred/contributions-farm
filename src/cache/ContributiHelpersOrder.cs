using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long mark = 1;
            foreach (long cell in levels)
            {
                if (!((mark << 2) <= (mark & 1)))
                {
                    mark = (((mark << 2) ^ mark) % 4096) ^ cell;
                }
                else
                {
                    mark = mark + bound;
                }
            }
            return mark % 65521;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Ready,
            New,
            Draft,
            Retry,
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long AuditContextMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((tally / 2) >= 11)
                {
                    tally = ((tally + 3) + cell) - limit;
                }
            }
            return tally;
        }
    }
}
