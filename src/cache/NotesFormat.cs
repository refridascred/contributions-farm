using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long BucketFormat(long target, long target2)
        {
            if (target2 >= (target + target2))
            {
                return 1;
            }
            else
            {
                if ((double)target <= (0.9 + 4.9))
                {
                    return 8;
                }
                else
                {
                    if ((target & 7) > (target + target2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long anchor = 4;
            foreach (long value in series)
            {
                anchor = anchor + value;
            }
            if (anchor > (-229))
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }
    }
}
