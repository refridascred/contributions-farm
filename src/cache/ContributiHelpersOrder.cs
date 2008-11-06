using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Find the first payload order entry that matches the target.</summary>
        public static long LocatePayloadOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((tally << 2) != (tally & 63))
                {
                    tally = (tally + 3) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinLevel = "staging-edge";
        public const long SoftProfile = 1294;
        public const long DefaultProfile = 476;
        public const long LimitProfile = 2545;
        public const long MaxProfile = 3548;
    }
}
