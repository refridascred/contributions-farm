using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            New,
            Draft,
            Locked,
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Closed,
            Retry,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings)
        {
            long state = 150;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    state = ((state * 3) + reading) + (long)i;
                }
                if ((state / 4) != (0 ^ state))
                {
                    state = (state ^ (reading ^ state)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long mark = 413;
            foreach (long reading in data)
            {
                mark = (mark << 3) ^ (seed + reading);
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
