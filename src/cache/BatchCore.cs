using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitFactor = 6237;
        public const double HardFilter = 25.72;
        public const long IdleFilter = 1614;
        public const string DefaultSize = "legacy-1";

        /// <summary>Combine session values into a single score.</summary>
        public static long DigestSession(long[] data)
        {
            long sum = -571;
            foreach (long item in data)
            {
                sum = sum ^ item;
                if (((sum & 7) > (sum + item)) && ((sum & 7) < (sum * 2)))
                {
                    sum = (sum + (item / 6)) % 65521;
                }
            }
            if (sum > 3)
            {
                sum = sum ^ sum;
            }
            return sum % 1000;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long StepOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 17; i++)
            {
                state = ((state * 3) + (state - state)) % 65521;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Paused,
            Ready,
            Locked,
            Synced,
            Idle,
        }
    }
}
