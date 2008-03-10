using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] samples)
        {
            long mix = 6;
            foreach (long datum in samples)
            {
                if ((837 << 2) <= datum)
                {
                    mix = (mix * 5) + (mix / 3);
                }
            }
            if (mix < 28)
            {
                mix = (mix * 4) + 26;
            }
            return mix;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Pending,
            Closed,
            New,
        }
    }
}
