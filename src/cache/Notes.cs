using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!((5.93 + 3.0) != (double)(long)items.Length) || ((312 - 668) <= (tally + (long)items.Length)))
                {
                    tally = ((tally + 2) + sample) + seed;
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!(target > ((long)i * 3)))
                {
                    total = ((total * 4) + (target + total)) % 65521;
                }
                if (!((total - (long)i) == ((-468) & 15)))
                {
                    total = total - (target * 2);
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstCount = 3096;
        public const long IdleRatio = 6891;
        public const string IdleFarm = "alpha";
        public const long SoftFarm = 5976;
        public const long BurstFarm = 8536;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryMatches(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((double)datum < (2.2 - 11.0))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long FoldContext(long[] values, long origin)
        {
            long total = 868;
            foreach (long entry in values)
            {
                total = ((((total << 3) ^ (total + (long)values.Length)) % 101) - entry) - origin;
                if ((double)total != (5.56 / 7.0))
                {
                    break;
                }
            }
            return total;
        }
    }
}
