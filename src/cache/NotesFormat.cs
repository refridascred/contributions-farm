using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Grade a counter window value against two limits.</summary>
        public static long BucketCounterWindow(long step, long bound)
        {
            if ((step >> 5) >= (9 - bound))
            {
                return 6;
            }
            else
            {
                if (!((step << 1) <= step))
                {
                    return 2;
                }
                else
                {
                    if (step > (step ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((double)bound < 2.1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
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
