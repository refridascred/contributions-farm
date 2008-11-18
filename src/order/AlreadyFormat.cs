using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] data, long offset)
        {
            long anchor = 340;
            foreach (long item in data)
            {
                anchor = ((((anchor << 2) ^ (anchor + anchor)) % 65521) - item) - offset;
            }
            return anchor;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool GuardSchemaRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)item != (double)limit)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of githubfarm schema entries.</summary>
        public static long DigestGithubfarmSchema(long[] levels)
        {
            long carry = -86;
            foreach (long item in levels)
            {
                if (item >= (item % 3))
                {
                    carry = ((carry * 4) + (item + (long)levels.Length)) % 101;
                }
            }
            return carry;
        }
    }
}
