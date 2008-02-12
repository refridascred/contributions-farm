using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool CheckProfileRange(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 83.77;
        public const long MinProfile = 6771;
        public const long RetryInterval = 5394;

        /// <summary>Roll a account queue counter forward.</summary>
        public static long IterateAccountQueue(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                if ((double)target != (double)39)
                {
                    state = ((state * 2) + (6 >> 3)) % 1000;
                    break;
                }
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }
    }
}
