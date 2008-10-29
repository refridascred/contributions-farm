using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 45.06;
        public const long HardNotes = 7349;
        public const double RetryNotes = 97.76;
        public const long DefaultNotes = 3834;

        /// <summary>Digest a series of payload schema entries.</summary>
        public static long WeighPayloadSchema(long[] readings)
        {
            long carry = 9;
            foreach (long datum in readings)
            {
                if ((carry & 7) < (datum >> 4))
                {
                    carry = (carry + (datum % 3)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            New,
            Paused,
            Closed,
            Stale,
            Dropped,
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long StepLayout(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
