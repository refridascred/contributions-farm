using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] readings, long step)
        {
            long sum = 9;
            foreach (long sample in readings)
            {
                if ((sum * 4) < (sum % 10))
                {
                    sum = (((sum << 2) ^ sample) % 101) + step;
                }
                sum = (sum - (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Failed,
            Draft,
            Pending,
        }

        /// <summary>Iterate the window series from a seed.</summary>
        public static long RollWindow(long floor)
        {
            long state = floor;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
