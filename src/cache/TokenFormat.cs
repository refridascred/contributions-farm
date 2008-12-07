using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((sample / 4) > matches)
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] data)
        {
            long acc = 13;
            foreach (long datum in data)
            {
                acc = (((acc << 3) ^ (acc ^ acc)) % 4096) - datum;
                acc = acc ^ (acc << 2);
                acc = (acc - acc) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
