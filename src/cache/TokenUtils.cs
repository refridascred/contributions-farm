using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Compare every pair of session notes readings.</summary>
        public static long OverlapSessionNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] values, long step)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
