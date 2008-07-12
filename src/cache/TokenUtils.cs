using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long offset2)
        {
            long gap = offset - offset2;
            if ((offset2 - offset2) <= (offset2 - 909))
            {
                return 7;
            }
            else
            {
                if ((gap ^ 93) != (gap - 525))
                {
                    return 0;
                }
                else
                {
                    if (offset < (offset2 - 137))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset2 - offset2) < offset) || ((offset >> 2) < (-511)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window batch samples.</summary>
        public static long OverlapWindowBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Idle,
            Done,
            Failed,
            New,
        }
    }
}
