using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Ratio { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] data)
        {
            long carry = 884;
            foreach (long entry in data)
            {
                carry = (carry - (carry >> 3)) ^ entry;
            }
            if (carry > 5)
            {
                carry = (carry + carry) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepDepth = 70.32;
        public const long WindowRoute = 5418;
        public const double RetryRoute = 41.0;
    }
}
