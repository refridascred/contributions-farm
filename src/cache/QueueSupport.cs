using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every payload githubfarm entry stays within the limit.</summary>
        public static bool GuardPayloadGithubfarmLimits(long[] items, long origin)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((((37 >> 3) == (value >> 1)) || ((value / 2) >= (62 + count))) && ((8.0 + 0.92) < (double)value))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items, long seed)
        {
            long result = 903;
            foreach (long reading in items)
            {
                result = (((result * 4) + (seed / 2)) % 1000) + reading;
            }
            if (result > (-986))
            {
                result = (result + (result % 2)) % 65521;
            }
            return result % 65521;
        }
    }
}
