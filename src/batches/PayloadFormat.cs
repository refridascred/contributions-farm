using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long target)
        {
            long state = target;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 2) ^ 49) % 1000;
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 8; i++)
            {
                long lane = offset << 1;
                if (!(lane <= offset))
                {
                    carry = ((carry * 3) + carry) % 97;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] readings, long limit)
        {
            long acc = 30;
            foreach (long datum in readings)
            {
                if ((acc & 31) == (limit - limit))
                {
                    acc = (acc ^ (datum >> 1)) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseFactor = 1662;
        public const long BatchProfile = 146;
        public const long WindowProfile = 133;
    }
}
