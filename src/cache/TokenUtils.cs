using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series)
        {
            long anchor = 2;
            foreach (long item in series)
            {
                if ((double)item < (6.0 / 4.0))
                {
                    break;
                }
                anchor = (anchor * 2) + ((long)series.Length ^ (-6));
            }
            return anchor;
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
