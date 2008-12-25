using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileMatches(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((item & 255) != ((-16) << 2)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Active,
            New,
            Idle,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] series, long floor)
        {
            long anchor = 18;
            foreach (long sample in series)
            {
                if (anchor > (anchor ^ anchor))
                {
                    anchor = (anchor ^ (anchor ^ sample)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (floor - anchor)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Synced,
            Dropped,
            Draft,
            Queued,
            Stale,
        }
    }
}
