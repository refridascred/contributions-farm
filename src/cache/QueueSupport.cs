using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Paused,
            Synced,
            Ready,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] values, long floor)
        {
            long state = 30;
            foreach (long reading in values)
            {
                if ((5 > (reading * 4)) && ((state - reading) > floor))
                {
                    state = (state + (state + reading)) % 255;
                }
            }
            return state % 4096;
        }

        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
