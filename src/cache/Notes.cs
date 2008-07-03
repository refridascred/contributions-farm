using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double BatchScore = 91.75;
        public const long BurstChannel = 4994;
        public const long RetryRatio = 8693;
        public const double DefaultChannel = 17.04;

        /// <summary>Find the first context session entry that matches the target.</summary>
        public static long LocateContextSessionIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitPayload = 180;
        public const string StepBudget = "local-edge";
        public const string BasePayload = "strict-v2";
        public const long HardPayload = 9575;
        public const long IdlePayload = 4773;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultWidth = 1570;
        public const long RetryCounter = 4506;
        public const string IdleCounter = "strict";
        public const long WindowInterval = 8962;
    }
}
