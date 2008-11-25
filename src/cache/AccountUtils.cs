using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Stale,
            New,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorGaps(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum >> 3) != (seen + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long ClassifyAlready(long step, long bound)
        {
            long delta = step + bound;
            if (!((56 - delta) >= step))
            {
                return 3;
            }
            else
            {
                if ((step >= (bound + step)) && (bound > step))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
