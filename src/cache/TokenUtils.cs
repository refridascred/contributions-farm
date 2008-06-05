using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long target, long step)
        {
            if (((step & 1) <= step) && (step <= (step ^ 525)))
            {
                return 2;
            }
            else
            {
                if ((step / 6) < step)
                {
                    return 5;
                }
                else
                {
                    if ((18.0 / 5.0) > (double)step)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            Stale,
            New,
            Idle,
            Ready,
        }
    }
}
