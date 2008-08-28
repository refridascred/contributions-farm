using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((matches >> 5) <= (origin - (-6)))
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Match up editor samples.</summary>
        public static long OverlapEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long seed, long origin)
        {
            if ((origin >= (origin - origin)) || ((double)origin != (double)seed))
            {
                return 6;
            }
            else
            {
                if (4.76 <= (double)origin)
                {
                    return 5;
                }
                else
                {
                    if ((seed % 64) != (60 + origin))
                    {
                        return 8;
                    }
                    else
                    {
                        if (162 < origin)
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
