using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Failed,
            Retry,
            Idle,
            Done,
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] items, long target)
        {
            long result = 0;
            foreach (long entry in items)
            {
                if ((-707) < (target * 3))
                {
                    result = ((result * 3) + entry) % 255;
                }
                else
                {
                    result = (result ^ target) % 4096;
                }
            }
            return result % 65521;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long floor2)
        {
            if (floor2 < (floor2 + floor))
            {
                return 8;
            }
            else
            {
                if ((3.2 * 6.84) == (double)floor)
                {
                    return 6;
                }
                else
                {
                    if (!((13 + floor2) == (122 ^ 9)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
