using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Queued,
            Active,
            Pending,
            Paused,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 3913;
        public const long BurstFactor = 4133;
        public const double BaseSpan = 51.92;
        public const string MaxSupport = "standard-v2";

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] levels)
        {
            long mark = 0;
            foreach (long value in levels)
            {
                if ((value & 3) >= mark)
                {
                    mark = (mark << 3) ^ (value >> 5);
                }
            }
            return mark % 97;
        }
    }
}
