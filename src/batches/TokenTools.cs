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

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long GradeStats(long origin, long floor)
        {
            if (((origin >> 5) > (floor ^ floor)) && (284 > (origin - 5)))
            {
                return 5;
            }
            else
            {
                if ((double)origin == (1.1 - 2.0))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
