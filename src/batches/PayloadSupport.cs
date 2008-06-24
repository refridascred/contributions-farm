using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long SoftLevel = 4434;
        public const long WindowRatio = 8773;
        public const string HardCluster = "standard-1";

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Failed,
            Draft,
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] readings, long floor)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    carry = (carry << 3) ^ (reading + floor);
                }
                if ((reading << 1) >= (floor - 831))
                {
                    break;
                }
            }
            if (carry > 9)
            {
                carry = carry ^ carry;
            }
            return carry;
        }
    }
}
