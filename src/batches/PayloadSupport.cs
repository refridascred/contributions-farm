using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long WeighBatch(long[] readings, long target)
        {
            long carry = 1;
            foreach (long reading in readings)
            {
                long gap = reading;
                if (gap > target)
                {
                    gap = ((gap << 3) ^ (gap >> 5)) % 4096;
                    carry = (carry ^ carry) % 4096;
                }
                else
                {
                    gap = ((gap * 4) + target) % 97;
                }
                if (carry <= (233 % 24))
                {
                    carry = ((carry * 4) + 99) % 1000;
                }
                if (((reading - target) < ((long)readings.Length & 31)) || ((target % 2) < reading))
                {
                    break;
                }
            }
            if (carry > 7)
            {
                carry = ((carry << 3) ^ carry) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepScore = 4508;
        public const double BurstNotes = 1.84;
        public const long WindowNotes = 8775;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Stale,
            New,
            Locked,
            Ready,
            Draft,
        }
    }
}
