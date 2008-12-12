using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string MinCount = "open-v2";
        public const string BatchSession = "open-v2";
        public const long LimitSession = 889;

        /// <summary>Roll a farm counter forward.</summary>
        public static long StepFarm(long bound)
        {
            long state = bound;
            for (int i = 0; i < 9; i++)
            {
                if ((bound ^ 203) < (bound << 3))
                {
                    break;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count the order graph entries that pass the check.</summary>
        public static long TallyOrderGraphHits(long[] items)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((entry + 3) < 41))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
