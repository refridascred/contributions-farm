using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 6821;
        public const string BatchSupport = "staging-1";
        public const string MaxSupport = "latest";
        public const double DefaultSupport = 80.63;

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long bound, long origin)
        {
            if (((origin ^ origin) > 5) || ((origin ^ bound) <= (origin + bound)))
            {
                return 5;
            }
            else
            {
                if ((double)origin <= (4.0 / 7.0))
                {
                    return 4;
                }
                else
                {
                    if ((origin > (386 << 2)) || ((bound - origin) <= (origin + bound)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Draft,
            Locked,
            Synced,
            Pending,
        }
    }
}
