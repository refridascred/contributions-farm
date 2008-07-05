using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 6;
            foreach (long datum in values)
            {
                sum = (sum * 3) + (datum + sum);
            }
            if (sum < (-7))
            {
                sum = ((sum << 3) ^ (37 >> 4)) % 4096;
            }
            return sum;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool ValidateGraphRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long item in readings)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionHits(long[] readings, long target)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((((entry << 3) <= (hits << 1)) && ((double)entry != (double)3)) || (252 <= (target << 3)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Dropped,
            Failed,
            Locked,
            Pending,
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxChecks = 4268;
        public const long BurstFactor = 9040;
        public const long SoftInterval = 7667;
    }
}
