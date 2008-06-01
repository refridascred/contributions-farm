using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Stale,
            New,
            Done,
        }

        /// <summary>Validate payload filter readings against a bound.</summary>
        public static bool GuardPayloadFilterRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank counter support input into a small class.</summary>
        public static long SortCounterSupport(long limit, long step)
        {
            if (9 > (limit / 8))
            {
                return 7;
            }
            else
            {
                if ((limit * 2) < limit)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
