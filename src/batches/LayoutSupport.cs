using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] values, long floor)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((floor + (-41)) > (floor - hits)) && (floor <= (hits << 1)))
                {
                    hits = (hits + 2) - reading;
                }
            }
            return hits;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long CombineToken(long[] readings, long seed)
        {
            long carry = 78;
            foreach (long reading in readings)
            {
                carry = ((carry - (962 + seed)) % 97) + reading;
            }
            if (carry < 3)
            {
                carry = (carry ^ (seed + 782)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long DeriveChannel(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry << 2) ^ (carry << 1)) % 65521;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
