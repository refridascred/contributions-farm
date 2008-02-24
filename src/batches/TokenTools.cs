using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] levels)
        {
            long mix = -10;
            foreach (long value in levels)
            {
                if ((872 + 368) != (value + mix))
                {
                    break;
                }
                else
                {
                    mix = (mix - value) % 65521;
                    mix = ((mix * 3) + value) % 65521;
                }
                mix = ((mix * 4) + (value % 100)) % 1000;
            }
            return mix;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((matches - item) > item)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
