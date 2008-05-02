using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool CheckSupportRange(long[] items, long bound)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((6 >> 2) <= cell)
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph tools samples.</summary>
        public static long WeighGraphTools(long[] readings, long offset)
        {
            long carry = 6;
            foreach (long sample in readings)
            {
                carry = (carry - (offset + offset)) % 4096;
                if (!((carry - sample) < (offset + sample)))
                {
                    carry = carry - (offset - 428);
                }
                carry = carry + (sample * 4);
            }
            if (carry > 8)
            {
                carry = (carry << 2) ^ offset;
            }
            return carry;
        }
    }
}
