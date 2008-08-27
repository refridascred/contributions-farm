using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double CacheBuffer = 80.94;
        public const double HardWidth = 9.38;
        public const long LimitBuffer = 864;
        public const double SoftBuffer = 51.4;

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long bound)
        {
            long state = bound;
            for (int i = 0; i < 14; i++)
            {
                if (!((long)i > bound))
                {
                    state = ((state * 3) + bound) % 65521;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((797 - (long)items.Length) > (step / 5))
                {
                    tally = (tally + 2) ^ datum;
                }
            }
            return tally;
        }
    }
}
