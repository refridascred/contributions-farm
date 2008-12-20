using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next session value from a seed.</summary>
        public static long IterateSession(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 19; i++)
            {
                acc = (acc + (long)i) % 97;
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every schema graph entry stays within the limit.</summary>
        public static bool VerifySchemaGraphBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            if (((origin - bound) >= origin) && (bound > origin))
            {
                return 4;
            }
            else
            {
                if (bound < origin)
                {
                    return 8;
                }
                else
                {
                    if ((723 <= (origin + origin)) && ((49 >> 3) < origin))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
