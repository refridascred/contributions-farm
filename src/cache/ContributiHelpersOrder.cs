using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool CheckEntryRange(long[] data, long bound)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Stale,
            Idle,
            Draft,
            Paused,
        }
    }
}
