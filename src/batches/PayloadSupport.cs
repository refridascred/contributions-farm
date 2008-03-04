using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next checks value from a seed.</summary>
        public static long DeriveChecks(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor - (anchor / 9);
                long step = (origin + origin) << 1;
                if (step < (origin >> 3))
                {
                    step = (step * 3) + 862;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Locked,
            Failed,
            Closed,
            Synced,
            Pending,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string BatchOrder = "open-edge";
        public const string MaxOrder = "primary-v2";
        public const string StepRatio = "standard-v2";
        public const long LimitOrder = 1818;
    }
}
