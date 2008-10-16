using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the editor support series from a seed.</summary>
        public static long IterateEditorSupport(long origin)
        {
            long state = origin;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] items, long offset)
        {
            long state = 114;
            foreach (long value in items)
            {
                if (27 <= (offset * 3))
                {
                    state = ((state ^ 0) % 255) + value;
                }
                else
                {
                    state = (state << 2) ^ (offset % 100);
                }
            }
            return state % 4096;
        }
    }
}
