using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank tools input into a small class.</summary>
        public static long BucketTools(long offset, long origin)
        {
            if ((double)origin != (double)offset)
            {
                return 8;
            }
            else
            {
                if (((offset + origin) <= origin) && ((offset - offset) == (55 - 66)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Done,
            Queued,
            Retry,
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
