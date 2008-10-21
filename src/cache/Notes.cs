using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long state = -10;
            foreach (long value in levels)
            {
                if ((seed / 3) == (487 + seed))
                {
                    state = state - (value ^ seed);
                }
            }
            return state % 1000;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Locked,
            Retry,
            New,
            Queued,
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if ((12.0 / 2.0) < (double)step)
                {
                    carry = (carry ^ (carry + carry)) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaGaps(long[] data, long seed)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (((double)seed > (19.0 + 5.8)) && !(hits > (seed + hits)))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }
    }
}
