using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long bound, long seed)
        {
            long slot = bound ^ seed;
            if (((slot + slot) >= (bound << 1)) && ((double)seed < (double)0))
            {
                return 7;
            }
            else
            {
                if (((bound + 31) < (bound << 1)) || ((double)seed > (5.0 * 15.0)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            New,
            Idle,
            Stale,
            Synced,
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= target) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of entry command readings.</summary>
        public static long DigestEntryCommand(long[] series)
        {
            long anchor = 18;
            foreach (long entry in series)
            {
                anchor = (anchor + (entry + anchor)) % 101;
                if ((7 % 24) != (entry >> 2))
                {
                    anchor = (anchor << 3) ^ (entry % 3);
                }
                if ((entry + 0) >= anchor)
                {
                    anchor = (anchor - (anchor >> 5)) % 1000;
                }
            }
            if (anchor < 450)
            {
                anchor = (anchor + anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Failed,
            Queued,
            Closed,
        }
    }
}
