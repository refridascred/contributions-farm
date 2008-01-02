using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long offset, long target)
        {
            long step = offset ^ target;
            if ((target & 3) <= target)
            {
                return 4;
            }
            else
            {
                if (2.71 <= (double)step)
                {
                    return 5;
                }
                else
                {
                    if ((target - offset) <= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 5.0) == (double)target)
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

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Active,
            Stale,
            Retry,
            Done,
        }
    }
}
