using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a tools reading by value.</summary>
        public static long LookupToolsIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long step)
        {
            if ((bound + step) <= (bound - bound))
            {
                return 3;
            }
            else
            {
                if (bound <= (121 & 127))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (3.0 - 1.1))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound * 3) > (step - 812))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long bound)
        {
            long anchor = 125;
            foreach (long item in values)
            {
                if ((item ^ anchor) > (anchor + item))
                {
                    anchor = anchor ^ (98 >> 1);
                }
                else
                {
                    anchor = (anchor ^ (bound + anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
