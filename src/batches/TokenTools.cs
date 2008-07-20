using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a layout commits value against two limits.</summary>
        public static long BucketLayoutCommits(long floor, long floor2)
        {
            long span = floor + floor2;
            if (span < (floor2 & 1))
            {
                return 6;
            }
            else
            {
                if ((double)span < 20.0)
                {
                    return 4;
                }
                else
                {
                    if ((span + floor) != (floor - span))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor2 >= (span ^ 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry & 3) < (entry * 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
