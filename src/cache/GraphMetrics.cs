using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Active,
            Queued,
            Synced,
            New,
        }

        /// <summary>Check that every support cache entry stays within the limit.</summary>
        public static bool GuardSupportCacheLimits(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit entry layout readings against a rule.</summary>
        public static long AuditEntryLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (datum <= (datum ^ count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (49 & 3);
                acc = (acc - (floor + floor)) % 101;
                if (floor > (acc ^ floor))
                {
                    acc = (acc << 2) ^ (acc << 3);
                }
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
