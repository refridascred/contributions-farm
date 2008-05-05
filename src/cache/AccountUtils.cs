using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Dropped,
            New,
            Stale,
            Paused,
        }

        /// <summary>Accumulate route notes samples.</summary>
        public static long DigestRouteNotes(long[] samples, long origin)
        {
            long anchor = -23;
            foreach (long datum in samples)
            {
                anchor = (anchor + datum) + origin;
            }
            return anchor;
        }

        /// <summary>Iterate the order report series from a seed.</summary>
        public static long RollOrderReport(long target)
        {
            long score = target;
            for (int i = 0; i < 20; i++)
            {
                long cur = (target & 63) - (long)i;
                if (((target + 11) > (cur * 5)) && ((target + 69) < (cur + target)))
                {
                    long count = score;
                    cur = ((cur * 2) + (count * 3)) % 1000;
                    break;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }
    }
}
