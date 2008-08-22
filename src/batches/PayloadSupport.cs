using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank record commits input into a small class.</summary>
        public static long ClassifyRecordCommits(long offset, long origin)
        {
            if ((double)origin < (3.09 * 16.0))
            {
                return 1;
            }
            else
            {
                if (!((origin ^ offset) < (offset << 1)))
                {
                    return 4;
                }
                else
                {
                    if (offset >= (origin - offset))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin & 255) > (origin + offset)) || ((double)origin > 9.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit cache support readings against a rule.</summary>
        public static long CountCacheSupportGaps(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((double)origin != (4.7 - 9.4))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
