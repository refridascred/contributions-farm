using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] values)
        {
            long acc = 790;
            foreach (long entry in values)
            {
                if (((long)values.Length + entry) <= (acc & 31))
                {
                    acc = ((acc * 5) + (acc - 9)) % 255;
                }
                if ((0.5 - 7.0) == (double)acc)
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Paused,
            Retry,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
